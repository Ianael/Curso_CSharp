using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer {
    class Program {
        static void Main(string[] args) {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //IPV4, stream, confirmação

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); //10.7.2.8

            socket.Bind(endPoint);

            socket.Listen(5);

            Console.WriteLine("Escutando...");
            Console.WriteLine();

            Socket escutando = socket.Accept();

            byte[] buffer = new byte[255];

            int tamanho = escutando.Receive(buffer, 0, buffer.Length, SocketFlags.None);

            Array.Resize(ref buffer, tamanho);

            Console.Write("Recebido: ");
            Console.WriteLine(Encoding.Default.GetString(buffer));

            socket.Close();

            Console.WriteLine();
            Console.Write("Comunicação finalizada! \nPressione qualquer tecla para fechar...");
            Console.ReadKey();
        }
    }
}
