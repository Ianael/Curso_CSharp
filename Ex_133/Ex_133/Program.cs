﻿using System;
using System.Collections.Generic;
using Ex_133.Entities;

namespace Ex_133 {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'c' || ch == 'C') {
                    list.Add(new Product(name, price));
                } else if (ch == 'u' || ch == 'U') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                } else if (ch == 'i' || ch == 'I') {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    list.Add(new ImportedProduct(name, price, customsFee));
                } else {
                    Console.WriteLine("Opção Inválida!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            
            foreach (Product prod in list) { 
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}
