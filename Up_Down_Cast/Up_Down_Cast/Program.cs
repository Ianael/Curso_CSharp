﻿using System;
using Up_Down_Cast.Entities;

namespace Up_Down_Cast {
    class Program {
        static void Main(string[] args) {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, "Ana", 0, 0.01);


            //DOWNCASTING - evitar
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100);
            
            //acc2.Loan(100);
            //BusinessAccount acc5 = (BusinessAccount)acc3; //Apesar de n indicar da erro
            
            if (acc3 is BusinessAccount) { //Testa antes de tentar converter
                //BusinessAccount acc5 = (BusinessAccount)acc3; 
                BusinessAccount acc5 = acc3 as BusinessAccount; //Cast usando AS
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            /*if (acc3 is SavingsAccount) { //Testa antes de tentar converter
                BusinessAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }*/
        }
    }
}
