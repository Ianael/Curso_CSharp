using System;
using GetHashCode_e_Equals.Entities;

namespace GetHashCode_e_Equals {
    class Program {
        static void Main(string[] args) {
            /*string a = "Alex";
            string b = "Alan";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode()); //Gera um cod para o obj, pode eventualmente ser igual
            Console.WriteLine(b.GetHashCode());*/ //Em uma lista grande usa-se Hash para encontrar val iguais e depois confere-se com Equals

            Client a = new Client { Name = "Maria", Email = "maria@mail.com" };
            Client b = new Client { Name = "Joao", Email = "joao@mail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); //Compara referencia do ponteiro do obj
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
