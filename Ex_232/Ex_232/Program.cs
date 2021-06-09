using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Ex_232.Entities;

namespace Ex_232 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Ex_232\in.txt";

            List<Product> list = new List<Product>();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while(!sr.EndOfStream){
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);

                        list.Add(new Product(name, price));
                    }
                }

                var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Avarage price = " + avg.ToString("f2", CultureInfo.InvariantCulture));

                Console.WriteLine();
                var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
                foreach(string n in names) {
                    Console.WriteLine(n);
                }


            }catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
