using System;
using System.Collections.Generic;
using HashSet_e_SortedSet.Entities;

namespace HashSet_e_SortedSet { //Não permite repetição na lista, n possui posição(hash) 
                                //(sorted)árvore com valores ordenados implementação IComparer<T>
    class Program {
        static void Main(string[] args) {
            /*HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Table");

            Console.WriteLine(set.Contains("Notebook"));
            Console.WriteLine(set.Contains("d20"));
            Console.WriteLine();

            foreach (string obj in set) {
                Console.WriteLine(obj);
            }*/

            /*SortedSet<int> a = new SortedSet<int>() { 0, 1, 2, 3, 4, 5 };
            SortedSet<int> d = new SortedSet<int>() {2, 4, 6, 8, 10, 12, 20};
            Console.WriteLine();

            PrintCollection(a);
            PrintCollection(d);

            //Union - add differente d elements to a
            SortedSet<int> u = new SortedSet<int>(a);
            u.UnionWith(d);
            Console.Write("União a d: " );
            PrintCollection(u);

            //Intersection - equal elements in d and a
            SortedSet<int> i = new SortedSet<int>(a);
            i.IntersectWith(d);
            Console.Write("Intersecção a d: ");
            PrintCollection(i);

            //Difference - diferrent elements in a compared to d
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(d);
            Console.Write("Diferença a d: ");
            PrintCollection(e);*/

            HashSet<Product> a = new HashSet<Product>();
            HashSet<Point> b = new HashSet<Point>();
            
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));
            
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);

            Console.WriteLine(a.Contains(prod)); //False se não implementar Equals e HashCode

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); //struct compara por conteúdo não referência
        }

        static void PrintCollection<T>(IEnumerable<T> collection) { //IEnumerable contem todas as coleções
            foreach(T obj in collection){
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
