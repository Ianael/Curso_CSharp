using System;

namespace Metodos_Extensao {
    class Program {
        static void Main(string[] args) {
            DateTime dt = new DateTime(2021, 6, 9, 8, 10, 5);
            Console.WriteLine(dt.ElapsedTime());

            String s = "Good morning dear students!";
            Console.WriteLine(s.Cut(10));
        }
    }
}
