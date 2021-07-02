using System;

namespace Recursividade {
    class Program {
        static int Fatorial(int num) {
            if (num <= 0)
                return 1;
            
            return num * Fatorial(num-1);
        }
        
        static void Main(string[] args) {
            Console.Write("Deseja saber o fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());
            
            int result = Fatorial(num);

            Console.WriteLine();
            Console.WriteLine($"O fatorial de {num} é {result}");
        }
    }
}
