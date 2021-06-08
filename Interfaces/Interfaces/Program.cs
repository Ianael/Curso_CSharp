using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter rental data: ");

                Console.Write("Car model: ");
                string model = Console.ReadLine();

                Console.Write("Pickup date (DD/MM/YYYY hh:mm): ");
                DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Return date (DD/MM/YYYY hh:mm): ");
                DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                Console.Write("Price per hour: ");
                double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Price per day: ");
                double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                CarRental carRental = new CarRental(start, finish, new Vehicle(model));
                RentalService rentalService = new RentalService(hour, day, new BrazillianTaxService());

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine();
                Console.WriteLine("INVOICE: ");
                Console.WriteLine(carRental.Invoice);
            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
