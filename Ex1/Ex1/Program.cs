using System;

namespace Ex1 {
    class Program {
        static void Main(string[] args) {
            string produto1 = "Computador", produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo preço é ${preco2}");
            Console.WriteLine();
            Console.WriteLine("Registro: 30 anos de idade, código {0} e gênero: {1}", codigo, genero);
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {medida:f8}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:f3}");
            Console.WriteLine($"Separador decimal invariant culture: " + medida.ToString("f3", System.Globalization.CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------------------------------------------------------------------------------------------");

            Console.Write("Escreva 3 palavras: ");
            string[] s = Console.ReadLine().Split();

            Console.WriteLine("Você digitou: {0}, {1} e {2}", s[0], s[1], s[2]);

        }
    }
}
