using System;
using Ex_146.Entities;
using Ex_146.Entities.Exceptions;

namespace Ex_146 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter account data: ");

                Console.Write("Number: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Initial balance: ");
                double iniBal = int.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                double withLim = int.Parse(Console.ReadLine());

                Account acc = new Account(num, name, iniBal, withLim);

                Console.Write("Enter the amount to withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                
                acc.Withdraw(withdraw);

                Console.WriteLine("New Balance: " + acc.Balance.ToString());
            } catch(DomainException e){
                Console.WriteLine("Withdraw Error: " + e.Message);
            }catch (Exception e) {
                Console.WriteLine("Unexpected ERROR: " + e.Message);
            }
        } 
    }
}
