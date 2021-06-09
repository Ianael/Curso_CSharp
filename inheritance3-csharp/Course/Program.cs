using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;
                acc.Withdraw(10);
                Console.WriteLine("Saldo Atualizado p/ " + acc.Number + ": " + acc.Balance.ToString());
            }

            Console.WriteLine("Soma total: " + sum);
        }
    }
}
