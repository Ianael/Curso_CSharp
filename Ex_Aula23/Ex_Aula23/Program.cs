using System;
using System.Globalization;

namespace Ex_Aula23 {
    class Program {
        static void Main(string[] args) {

            string nome, sobrenome;
            byte idade, quartos;
            float altura;
            decimal preco;


            Console.Write("Entre com o seu nome completo: ");
            nome = Console.ReadLine();
            Console.Write("Quantos quartos tem na sua casa? ");
            quartos = byte.Parse(Console.ReadLine());
            Console.Write("Entre com o preço de um produto: ");
            preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com seu último nome, idade e altura (mesma linha): ");
            string[] vect = Console.ReadLine().Split(' ');

            sobrenome = vect[0];
            idade = byte.Parse(vect[1]);
            altura = float.Parse(vect[2], CultureInfo.InvariantCulture);
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString(CultureInfo.InvariantCulture));

        }
    }
}
