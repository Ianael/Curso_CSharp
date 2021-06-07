using System;

namespace Ex_137.Entities {
    class Company : TaxPayer{
        public int Employees { get; set; }

        public Company(string name, double income, int employees) : base(name, income) {
            Employees = employees;
        }

        public override double Taxes() {
            if (Employees > 10) {
                return Income * 0.14;
            }
            return Income * 0.16;
        }
    }
}
