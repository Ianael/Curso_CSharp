using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer {
    //Necessário para especificar os paramentros passados com o evento
    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
    
    class Servidor {
        //Armazena usuários e conexões
        public static Hashtable htUsuarios = new Hashtable(30); //Limite de usuários
        
        public static Hashtable htConexoes = new Hashtable(30); //Limite de conexões

        //Armazena o endereço IP
        private IPAddress enderecoIP;
        private int portaHost;
        private TcpClient tcpClient;

        public static event StatusChangedEventHandler StatusChanged;
        public static StatusChangedEventArgs e;

        //O contrutor define o enderço IP retornado pela instanciação do objeto
        public Servidor(IPAddress endereco, int porta) {
            enderecoIP = endereco;
            portaHost = porta;
        }

        //Thread que ira tratar o escutador de conexões
        private Thread thrListener;

        //Objeto TCP que escuta as conexões
        private TcpListener tlsCliente;

        //Diz ao laço while para manter a monitoração das conexões
        bool ServerRodando = false;

        public static void IncluiUsuario(TcpClient tcpUsuario, string strUsername) {
            //Primeiro incluí o nome e conexão associada para ambas as hash tables 
            Servidor.htUsuarios.Add(strUsername, tcpUsuario);
            Servidor.htConexoes.Add(tcpUsuario, strUsername);

            //Informa nova conexão p/ usuário e formulário
            EnviaMensagemAdmin(htConexoes[tcpUsuario] + " entrou...");
        }

        //Remove usuário das Hashtables
        public static void RemoveUsuario(TcpClient tcpUsuario) {
            if (htConexoes[tcpUsuario] != null) { //Se user existir
                //Informa outros usuários
                EnviaMensagemAdmin(htConexoes[tcpUsuario] + " saiu...");

                //Remove
                Servidor.htUsuarios.Remove(Servidor.htConexoes[tcpUsuario]);
                Servidor.htConexoes.Remove(tcpUsuario);
            }
        }

        //Chamado quando om evento StatusChanged é disparado
        public static void OnStatusChanged(StatusChangedEventArgs e) {
            StatusChangedEventHandler statusHandler = StatusChanged;

            if (statusHandler != null) {
                //Invoca delegate
                statusHandler(null, e);
            }
        }

        //Envia mensagens administrativas
        public static void EnviaMensagemAdmin(string Mensagem) {
            StreamWriter swSender;

            //Exibe na aplicação
            e = new StatusChangedEventArgs("Administrador: " + Mensagem);
            OnStatusChanged(e);

            //Array de clientes TCP existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            for (int i = 0; i < tcpClientes.Length; i++) {
                //Tenta enviar 1 msg p/ cada cliente
                try {//Se a msg estiver em branco ou a conexão for nula sai...
                    if (string.IsNullOrEmpty(Mensagem.Trim()) || tcpClientes[i] == null) {
                        continue;
                    }

                    swSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSender.WriteLine("Administrador: " + Mensagem);
                    swSender.Flush();
                    swSender = null;
                } catch {
                    //Se ocorrer algum erro, remove o usuário, pois ele não existe
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        //Envia a mensagem de um usuário para todos os usuários
        public static void EnviaMensagem(string Origem, string Mensagem) {
            StreamWriter swSender;

            e = new StatusChangedEventArgs(Origem + " disse: " + Mensagem);
            OnStatusChanged(e);

            //Array de clientes TCP existentes
            TcpClient[] tcpClientes = new TcpClient[Servidor.htUsuarios.Count];
            Servidor.htUsuarios.Values.CopyTo(tcpClientes, 0);

            for (int i = 0; i < tcpClientes.Length; i++) {
                //Tenta enviar 1 msg p/ cada cliente
                try {//Se a msg estiver em branco ou a conexão for nula sai...
                    if (string.IsNullOrEmpty(Mensagem.Trim()) || tcpClientes[i] == null) {
                        continue;
                    }

                    swSender = new StreamWriter(tcpClientes[i].GetStream());
                    swSender.WriteLine(Origem + " disse: " + Mensagem);
                    swSender.Flush();
                    swSender = null;
                } catch {
                    //Se ocorrer algum erro, remove o usuário, pois ele não existe
                    RemoveUsuario(tcpClientes[i]);
                }
            }
        }

        public void IniciaAtendimento() {
            try {
                //Pega IP
                IPAddress ipLocal = enderecoIP;
                int portaLocal = portaHost;

                //Cria objeto TCP Listener e escuta conexões
                tlsCliente = new TcpListener(ipLocal, portaLocal);
                tlsCliente.Start();

                ServerRodando = true;

                //Inicia thread que hospeda o listener
                thrListener = new Thread(MantemAtendimento);
                thrListener.IsBackground = true;
                thrListener.Start();

            } catch { }
        }

        private void MantemAtendimento() {
            //Enquanto servidor estiver rodando
            while (ServerRodando) {
                //Aceita conexão pendente
                tcpClient = tlsCliente.AcceptTcpClient();
                //Cria uma nova instancia da conexão
                Conexao newConnection = new Conexao(tcpClient);
            }
        }
    }
}
