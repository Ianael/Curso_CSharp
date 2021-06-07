using System;
using System.Collections.Generic;
using Metodo_Abstrato.Entities;
using Metodo_Abstrato.Entities.Enums;

namespace Metodo_Abstrato {
    class Program {
        static void Main(string[] args) {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine();
                Console.Write($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r' || ch == 'R') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, width, height));
                } else if (ch == 'c' || ch == 'C') {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                } else {
                    Console.WriteLine("Inválido!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (Shape shp in list) {
                Console.WriteLine(shp.Area().ToString());
            }
        }
    }
}

