using System;
using Excecoes_Personalizadas.Entities;
using Excecoes_Personalizadas.Entities.Exceptions;

namespace Excecoes_Personalizadas {
    class Program {
        static void Main(string[] args) {
            try {
                Console.Write("Room number: ");
                int num = int.Parse(Console.ReadLine());

                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime ckin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime ckout = DateTime.Parse(Console.ReadLine());


                Reservation res = new Reservation(num, ckin, ckout);
                Console.WriteLine("Reservation: " + res);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation: ");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                ckin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date (dd/MM/yyyy): ");
                ckout = DateTime.Parse(Console.ReadLine());

                res.UpdateDates(ckin, ckout);
                Console.WriteLine("Reservation: " + res);
            } catch (DomainException e) {
                Console.WriteLine("Error in Reservation: " + e.Message);
            }
        }
    }
}

