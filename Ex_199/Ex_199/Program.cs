using System;
using System.Globalization;
using Ex_199.Entities;
using Ex_199.Services;

namespace Ex_199 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter contract data: ");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                Console.Write("Contract value: ");
                double value = double.Parse(Console.ReadLine());

                Console.Write("Enter number of installments: ");
                int months = int.Parse(Console.ReadLine());

                Contract contract = new Contract(number, date, value);

                ContractProcess contractProcess = new ContractProcess(new PaymentService());
                contractProcess.ProcessContract(contract, months);

                Console.WriteLine();
                Console.WriteLine("INSTALLMENTS: ");
                foreach(Installment x in contract.Installments){
                    Console.WriteLine(x);
                }
            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
