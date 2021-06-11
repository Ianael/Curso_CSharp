using System;
using Delegates.Services;

namespace Delegates {
    class Program {

        //delegate double BinaryNumericOperation(double n1, double n2);
        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args) {
            double a = 10;
            double b = 12;
            
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            //double result = CalculationService.Max(a, b); //Maior
            //double result = op(a, b);

            op.Invoke(a, b); //Invoke executa todos os metodos na ordem que foram adicionados (utilizar metodos void)
            op(a, b);

            //Console.WriteLine(result);
        }
    }
}
