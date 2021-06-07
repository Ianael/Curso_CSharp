using System;
using System.Globalization;

namespace Ex_Classe {
    public class Triangulo {
        public double A;
        public double B;
        public double C;
        public double Area;
        public void Area_triangulo() { 
            double p = (A + B + C) / 2;
            Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    class Program {
        static void Main(string[] args) {
            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            Console.Write("Insira as medidas do triângulo X: ");

            X.A = double.Parse(Console.ReadLine());
            X.B = double.Parse(Console.ReadLine());
            X.C = double.Parse(Console.ReadLine());

            Console.Write("Insira as medidas do triângulo Y: ");
            Y.A = double.Parse(Console.ReadLine());
            Y.B = double.Parse(Console.ReadLine());
            Y.C = double.Parse(Console.ReadLine());

            X.Area_triangulo();
            Y.Area_triangulo();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("A área de X é: " + X.Area.ToString("f4"));
            Console.WriteLine("A área de Y é: " + Y.Area.ToString("f4"));
            if (X.Area == Y.Area) {
                Console.WriteLine("As áreas de X e Y são iguais!");
            } else if (X.Area > Y.Area) {
                Console.WriteLine("A maior área é a do triângulo X");
            } else {
                Console.WriteLine("A maior área é a do triângulo Y");
            }
        }

    }
}

