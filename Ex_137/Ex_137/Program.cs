using System;
using System.Collections.Generic;
using Ex_137.Entities;

namespace Ex_137 {
    class Program {
        static void Main(string[] args) {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i=1; i <=n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i}: ");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i' || ch == 'I') {
                    Console.Write("Health expanditures: ");
                    double health = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, health));
                }else if (ch == 'c' || ch == 'C') {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                } else {
                    Console.WriteLine("Opção Inválida");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("TAXES PAID: ");

            double sum = 0.0;
            foreach (TaxPayer payer in list) {
                Console.WriteLine(payer.Name + ": $" + payer.Taxes());
                sum += payer.Taxes();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${sum}");
        }
    }
}
