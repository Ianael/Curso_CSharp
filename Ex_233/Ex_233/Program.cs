using System;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using Ex_233.Entities;

namespace Ex_233 {
    class Program {
        static void Main(string[] args) {
            string path = @"C:\Users\ianael\Documents\curso_csharp\Ex_233\in.txt";

            List<Employee> list = new List<Employee>();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) { 
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, email, salary));
                    }
                }

                Console.Write("Enter Salary: ");
                double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.WriteLine($"Email of people whose salary is more than ${sal}: ");
                var more = list.Where(e => e.Salary > sal).OrderBy(e => e.Email).Select(e => e.Email);
                foreach(string emp in more){
                    Console.WriteLine(emp);
                }

                Console.WriteLine();
                Console.WriteLine("Sum of salary of people whose name starts with 'M': ");
                double sum = list.Where(e => e.Name[0] == 'M').Select(e => e.Salary).DefaultIfEmpty(0.0).Sum();
                Console.Write(sum.ToString(CultureInfo.InvariantCulture));
            } catch(Exception e){
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
