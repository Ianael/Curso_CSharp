using System;

namespace Ex_137.Entities {
    class Individual : TaxPayer{
        public double HealthInsurance { get; set; }

        public Individual(string name, double income, double healthInsurance) : base(name, income) {
            HealthInsurance = healthInsurance;
        }

        public override double Taxes() {
            if (Income < 20000) {
                return (Income * 0.15)-(HealthInsurance * 0.5);
            }
            return (Income * 0.25) - (HealthInsurance * 0.5);
        }
    }
}
