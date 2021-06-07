using System;
using System.Globalization;



namespace Funcoes {
    class Program {
        static int Maior(int n1, int n2, int n3) {
            if (n1 > n2 && n1 > n3) {
                return n1;
            } else if (n2 > n3) {
                return n2;
            } else {
                return n3;
            }
        }

        static int Fatorial(int n) {
            int f = n;

            if (n == 0) {
                f = 1;
            } else {
                for (int i = 1; i != n; i++) {
                    f *= n - i;
                }
            }

            return f;
        }

        static void Main(string[] args) {
            //Função
            /*Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int n = Maior(n1, n2, n3);

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("O maior número é o " + n);*/

            //While
            /*Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (n >= 0.0) {
                double raiz = Math.Sqrt(n);
                Console.WriteLine("A raiz é: " + raiz.ToString("f3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro número: ");
                n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine("O número é negativo!");*/

            //FOR
            //Fatorial

            Console.Write("Insira um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            int f = Fatorial(n);
            Console.WriteLine($"O fatorial de {n} é: {f}");
        }
    }
}
