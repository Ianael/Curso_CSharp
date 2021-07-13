using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TransferirArquivoCliente {
    class FTCliente {
        static IPEndPoint ipEnd_Cliente;
        static Socket socket_Cliente;

        public static string EnderocoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static Label labelMensagem;

        public static void EnviarArquivo(string arquivo) {
            try {
                ipEnd_Cliente = new IPEndPoint(IPAddress.Parse(EnderocoIP), PortaHost);
                socket_Cliente = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf(@"\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf(@"\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);

                if (nomeArquivoByte.Length > (50000 * 1024)) {
                    labelMensagem.Invoke(new Action(() => {
                        labelMensagem.ForeColor = Color.Red;
                        labelMensagem.Text = "Tamanho de arquivo excedido! É maior que 50KB.";
                    }));
                    return;
                }

                string caminhoCompleto = pasta + arquivo;
                byte[] fileData = File.ReadAllBytes(caminhoCompleto);
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLenght = BitConverter.GetBytes(nomeArquivoByte.Length);

                nomeArquivoLenght.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);

                socket_Cliente.Connect(ipEnd_Cliente);
                socket_Cliente.Send(clientData, 0, clientData.Length, 0);

                socket_Cliente.Close();

                labelMensagem.Invoke(new Action(() => {
                    labelMensagem.ForeColor = Color.Green;
                    labelMensagem.Text = "Arquivo [" + arquivo + "] transferido.";
                }));

            } catch (Exception ex) {
                labelMensagem.Invoke(new Action(() => {
                    labelMensagem.ForeColor = Color.Red;
                    labelMensagem.Text = "Erro, O servidor não está atendendo..." + ex.Message;
                }));

            } finally {
                socket_Cliente.Disconnect(false);
                socket_Cliente.Close();
            }
        }
    }
}
