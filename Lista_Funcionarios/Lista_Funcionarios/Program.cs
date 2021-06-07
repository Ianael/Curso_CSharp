using System;
using System.Globalization;
using System.Collections.Generic; //Listas

namespace Lista_Funcionarios {
    class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> l = new List<Employee>(); //Class List

            int id;
            string name;
            double salary;
            for (int i=0; i<n ;i++) {
                Console.WriteLine("");
                Console.WriteLine("Employee #{0}", i+1);
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name = Console.ReadLine();

                Console.Write("Salary: ");
                salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                l.Add(new Employee(id, name, salary));
            }

            Console.WriteLine(" ");
     
            Console.Write("Enter the employee ID that will have the salary increase: ");
            int sal_id = int.Parse(Console.ReadLine());

            Employee inc = l.Find(x => x.Id == sal_id);
            if (inc != null) {
                Console.Write("Enter the percentage: ");
                double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) / 100;

                inc.IncreaceSalary(perc);
            } else {
               Console.WriteLine("This ID does not exist!");
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Updated list of employees:");

            foreach (Employee x in l) {
                Console.WriteLine(x);   
            }
        }
    }
}
