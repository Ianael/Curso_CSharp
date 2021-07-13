using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketCliente {
    class Program {
        static void Main(string[] args) {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //IPV4, stream, confirmação

            try {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); //10.7.2.8

                socket.Connect(endPoint);

                Console.WriteLine("Conectado com sucesso!");
                Console.WriteLine();
                Console.Write("Insira a informação a ser enviada: ");
                string info = Console.ReadLine();
                Console.WriteLine();

                byte[] buffer = Encoding.Default.GetBytes(info);
                socket.Send(buffer, 0, buffer.Length, SocketFlags.None);

                Console.WriteLine("Mensagem enviada!");
                Console.WriteLine();                
            } catch (Exception ex) {
                Console.WriteLine("Não foi possível conectar ao servidor! " + ex.Message);
            }

            socket.Close();

            Console.Write("Pressione uma tecla para fechar...");
            Console.ReadKey();
        }
    }
}
