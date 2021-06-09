using System;
using System.Collections.Generic;
using Ex_212.Entities;

namespace Ex_212 {
    class Program {
        static void Main(string[] args) {

            HashSet<Student> students = new HashSet<Student>();
            try {
                Console.Write("How many student in course A? ");
                int na = int.Parse(Console.ReadLine());

                for (int i=1; i <= na; i++) {
                    Console.Write($"#{i} code in A: ");
                    int s = int.Parse(Console.ReadLine());
                    students.Add(new Student(s));
                }

                Console.WriteLine();
                Console.Write("How many student in course B? ");
                int nb = int.Parse(Console.ReadLine());

                for (int i=1; i <= nb; i++) {
                    Console.Write($"#{i} code in B: ");
                    int s = int.Parse(Console.ReadLine());
                    students.Add(new Student(s));
                }

                Console.WriteLine();
                Console.Write("How many student in course C? ");
                int nc = int.Parse(Console.ReadLine());

                for (int i=1; i <= nc; i++) {
                    Console.Write($"#{i} code in C: ");
                    int s = int.Parse(Console.ReadLine());
                    students.Add(new Student(s));
                }

                Console.WriteLine();
                Console.WriteLine("Total students: " + students.Count);
            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
