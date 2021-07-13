using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TransferirArquivoServer {
    class FTServer {
        static IPEndPoint ipEnd_servidor;
        static Socket socket_Servidor;

        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static string EnderocoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static ListBox listaMensagem;

        public static void IniciarServidor() {
            try {
                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderocoIP), PortaHost);
                socket_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                socket_Servidor.Bind(ipEnd_servidor);

            } catch (Exception ex) {
                listaMensagem.Invoke(new Action(() => {
                    listaMensagem.Items.Add("Erro ao iniciar servidor: " + ex.Message);
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));
                
                return;
            }

            try {
                socket_Servidor.Listen(100);

                listaMensagem.Invoke(new Action(() => {
                    listaMensagem.Items.Add("Servidor em Atendimento: Aguardando para receber arquivo...");
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));

                Socket clienteSocket = socket_Servidor.Accept();
                clienteSocket.ReceiveBufferSize = 16384; //16KB

                byte[] dadosCliente = new byte[1024 * 50000]; //50MB

                int tamanhoBytesRecebidos = clienteSocket.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                BinaryWriter binaryWriter = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append));
                binaryWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo);

                while (tamanhoBytesRecebidos > 0) {
                    tamanhoBytesRecebidos = clienteSocket.Receive(dadosCliente, dadosCliente.Length, 0);

                    if (tamanhoBytesRecebidos == 0) {
                        binaryWriter.Close();
                    } else {
                        binaryWriter.Write(dadosCliente, 0, tamanhoBytesRecebidos);
                    }
                }

                listaMensagem.Invoke(new Action(() => {
                    listaMensagem.Items.Add("Arquivo recebido e arquivado [" + nomeArquivo + "] (" + (tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo) + " bytes recebido)");
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));

                binaryWriter.Close();
                clienteSocket.Close();
            } catch (SocketException ex) {
                listaMensagem.Invoke(new Action(() => {
                    listaMensagem.Items.Add("Erro ao receber arquivo: " + ex.Message);
                    listaMensagem.SetSelected(listaMensagem.Items.Count - 1, true);
                }));
            } finally {
                socket_Servidor.Close();
                socket_Servidor.Dispose();
                IniciarServidor();
            }
        }

    }
}
