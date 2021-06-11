using System;
using System.IO;

namespace Excecoes {
    class Program {
        static void Main(string[] args) {
            FileStream fs = null;

            /*int result = 0;
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                result = n1 / n2;
            } catch (DivideByZeroException e) {
                Console.WriteLine("ERROR! " + e.Message);
            } catch (FormatException) {
                Console.WriteLine("Erro de tipagem! ");
            }

            Console.WriteLine("Resultado: " + result.ToString());*/

            //Exemplo com arquivo
            try {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                if (fs != null) {
                    fs.Close();
                }
            }
        }
    }
}
