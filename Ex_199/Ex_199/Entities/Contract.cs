using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex_199.Entities {
    class Contract {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public Double TotalValue { get; private set; }
        public List<Installment> Installments = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
        }
    }
}
