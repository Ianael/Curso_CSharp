
namespace Sobreposicao.Entities {
    class Account {
        public int Number { get; private set; }
        public string Holder { get; private set; } //private -> acesso, mas não alteração
        public double Balance { get; protected set; } //protected -> acesso e alteração(por subclasses)

        public Account() { }
        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) { //Virtual -> pode ser sobrescrito
            Balance -= amount + 5.0; //Taxa para conta normal
        }

        public void Deposit(double amount) { 
            Balance += amount;
        }
    }
}
