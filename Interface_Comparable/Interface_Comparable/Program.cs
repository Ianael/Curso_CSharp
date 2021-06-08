using System;
using System.IO;
using System.Collections.Generic;
using Interface_Comparable.Entities;

namespace Interface_Comparable {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Interface_Comparable\funcionarios.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();

                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();

                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }


            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
