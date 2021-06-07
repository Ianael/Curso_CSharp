using System;
using System.Globalization;

namespace Cond_ternaria {
    class Program {
        static void Main(string[] args) {
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? (preco*0.1) : (preco*0.05);
            /*if (preco < 20.0) {
                desconto = preco * 0.1;
            } else {
                desconto = preco * 0.05;
            }*/
            
            Console.WriteLine("Desconto: " + desconto);

        }
    }
}
