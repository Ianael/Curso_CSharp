using System;
using System.Collections.Generic;

namespace Tipo_Generics {
    class Program {
        static void Main(string[] args) {
            try {
                PrintService printService = new PrintService();

                Console.Write("How many values? ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int i=0; i< n; i++) {
                    Console.Write($"Value #{i}: ");
                    int x = int.Parse(Console.ReadLine());
                    printService.AddValue(x);
                }

                Console.WriteLine();
                printService.Print();
                Console.WriteLine("First: " + printService.First());

            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
