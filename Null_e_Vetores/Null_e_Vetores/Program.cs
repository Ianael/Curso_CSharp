using System;

namespace Null_e_Vetores {
    class Program {
        public static int Soma(params int[] n) {
            int sum = 0;
            for (int i = 0; i < n.Length; i++) {
                sum += n[i];
            }
            return sum;
        }

        public static void Triple(ref int x) {
            x *= 3;
        }

        public static void Double(int x, out int result) {
            result = x * 2;
        }

        static void Main(string[] args) {
            //NULL
            /*
            double? a = null;
            double? b = 10;

            double c = a ?? 5; //?? -> Se estiver nullo recebe 
            double d = b ?? 5;
            Console.WriteLine(c);
            Console.WriteLine(d);
            */

            /*
            Console.Write("Insira o tamanho do vetor: ");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i=0; i<n; i++) {
                Console.Write("Insira o valor {0}: ", i);
                vect[i] = double.Parse(Console.ReadLine());
            }

            double sum = 0.0;
            foreach (int x in vect) {
                sum += x;
            }
            Console.WriteLine("A soma dos valores é {0}. ", sum);

            Console.WriteLine("A média dos valores é {0}. ", (sum/n));
            */
            int x = Soma(1, 2, 3, 4, 5);
            Console.WriteLine("Soma: {0}", x);

            //REF e OUT não são utilizados
            int a = 10;
            Triple(ref a);
            Console.WriteLine("Tiplicou para: {0}", a);

            int dobro;
            int b = 5;
            Double(b, out dobro);
            Console.WriteLine("Dobrou para: {0}", dobro);
        }
    }
}
