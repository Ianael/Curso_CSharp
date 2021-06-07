
namespace Sobreposicao.Entities {
    class SavingsAccount : Account { //sealed class SavingsAccount : Account{ não permite criar herdeiros
        public double InterestRate { get; set; }

        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void updateBalance() {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount) { //sealed -> evita que seja sobreposto novamente
            //Balance -= amount; //Conta Saving n tem taxa
            base.Withdraw(amount); //base -> chama função da superclasse
            Balance -= 2.0;
        }
    }
}
