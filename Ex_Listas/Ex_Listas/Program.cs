using System;
using System.Collections.Generic; //Listas

namespace Ex_Listas {

    class Program {
        static bool Test(string s) {
            return s[0] == 'A';
        }

        static void Main(string[] args) {
            List<string> l = new List<string> {"Mary", "Steve", "Robert"};
            List<string> list = new List<string>();

            list.Add("Black");
            list.Add("Anne");
            list.Add("Bob");
            list.Add("Sanders");
            list.Add("Andrew");

            list.Insert(2, "Mark");
            list.Insert(3, "Sandy");

            foreach (string x in list) {
                Console.WriteLine(x);   
            }

            Console.WriteLine(" ");
            Console.WriteLine("O tamanho da lista é: " + list.Count);
            Console.WriteLine("Primeiro elemento com A: " + list.Find(x => x[0] == 'A')); //list.Find(Test)
            Console.WriteLine("Último elemento com A: " + list.FindLast(x => x[0] == 'A'));
            Console.WriteLine(" ");

            Console.WriteLine("Primeira posição com A: " + list.FindIndex(x => x[0] == 'A'));
            Console.WriteLine("Última posição com A: " + list.FindLastIndex(x => x[0] == 'A'));
            Console.WriteLine(" ");

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Nomes com 5 characters: ");
            foreach (string x in list2) {
                Console.WriteLine(x);
            }

            Console.WriteLine(" ");
            list.Remove("Bob");
            foreach (string x in list) {
                Console.WriteLine(x);
            }

            Console.WriteLine(" ");
            list.RemoveAll(x => x[0] == 'S');
            foreach (string x in list) {
                Console.WriteLine(x);
            }

            Console.WriteLine(" ");
            list.RemoveAt(1);
            foreach (string x in list) {
                Console.WriteLine(x);
            }

            Console.WriteLine(" ");
            list.RemoveRange(0, 2); //(inicio, qnt)
            foreach (string x in list) {
                Console.WriteLine(x);
            }
        }
    }
}
