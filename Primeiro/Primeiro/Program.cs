using System;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {
            bool b = true;
            char beta = '\u03b2'; //unicode

            object obj = "Black"; //tipo genérico

            Console.WriteLine(obj);

            obj = 2.5f;

            Console.WriteLine(obj);

            //Min/Max -> tipo.MinValue ou tipo.MaxValue
            int n1 = int.MaxValue;
            Console.WriteLine(n1);

            Console.WriteLine("---------------------------------------------------------");

            double saldo = 12.567448;
            string s;

            s = saldo.ToString("F4"); //FN p número de casas decimais

            Console.WriteLine(s);

            Console.WriteLine("---------------------------------------------------------");

            int idade = 32;
            string nome = "João";
            Console.WriteLine("{0} tem {1} anos e saldo igual a {2:F2} reais.", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e saldo de {saldo:f2} reais.");
            Console.WriteLine(nome+ " tem " + idade + " anos.");
        }
    }
}

