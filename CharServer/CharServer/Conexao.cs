using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ChatServer {
    //Trata das conexões, são tantas quantos as instância do usuário conectados
    class Conexao {
        TcpClient tcpClient;

        //Thread que irá enviar a informação para o cliente
        private Thread thrSender;
        private StreamReader srReceptor;
        private StreamWriter swSender;
        private string usuarioAtual;
        private string strResposta;

        //Contrutor da classe
        public Conexao(TcpClient tcpCon) {
            tcpClient = tcpCon;

            //Thread que aceita o cliente espera a msg
            thrSender = new Thread(AceitaCliente);
            thrSender.IsBackground = true;

            //Thread chama método
            thrSender.Start();
        }

        private void FechaConexao() {
            //Fecha objetos abertos
            tcpClient.Close();
            srReceptor.Close();
            swSender.Close();
        }

        //Ocorre quando um novo cliente é aceito
        private void AceitaCliente() {
            srReceptor = new StreamReader(tcpClient.GetStream());
            swSender = new StreamWriter(tcpClient.GetStream());

            //Lê informações da conta da cliente
            usuarioAtual = srReceptor.ReadLine();

            //Respota do cliente
            if (usuarioAtual != "") {
                //Armazena nome do usuário na HashTable
                if (Servidor.htUsuarios.Contains(usuarioAtual) == true) {
                    //0 -> não conectado
                    swSender.WriteLine("0|Este nome de usuário já existe.");
                    swSender.Flush();
                    FechaConexao();
                    return;
                }else if (usuarioAtual == "Administrador") {
                    swSender.WriteLine("0|Este nome de usuário é reservado.");
                    swSender.Flush();
                    FechaConexao();
                    return;
                } else {
                    //1 -> conectado
                    swSender.WriteLine("1");
                    swSender.Flush();

                    //Incluí usuário na hashtable, inicia e escuta
                    Servidor.IncluiUsuario(tcpClient, usuarioAtual);
                }
            } else {
                FechaConexao();
                return;
            }

            try {
                //Aguarda msg do usuário
                while ((strResposta = srReceptor.ReadLine()) != "") {
                    //Se inválido remove
                    if (strResposta == null) {
                        Servidor.RemoveUsuario(tcpClient);
                    } else {
                        //Envia s msg p/ os outros usuários
                        Servidor.EnviaMensagem(usuarioAtual, strResposta);
                    }
                }
            } catch {
                //Se houve um problema desconecta usuário
                Servidor.RemoveUsuario(tcpClient);
            }
        }
    }
}
