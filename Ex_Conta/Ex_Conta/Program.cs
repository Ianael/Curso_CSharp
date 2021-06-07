using System;

namespace Ex_Conta {

    public class Conta {
        public int Numero {get; private set;}
        private string _titular;
        public double Saldo {get; private set;}

        public Conta(int numero, string titular){
            Numero = numero;
            _titular = titular;
        }
        public Conta(int numero, string titular, double saldo){
            Numero = numero;
            _titular = titular;
            Deposito(saldo);
        }

        public void Deposito(double val) {
            Saldo += val;
        }
        public void Saque(double val) {
            Saldo -= val + 5.0; //5 é a taxa de saque
        }

        public override string ToString() {
            return "Dados da conta:\nConta " + Numero
                + ", Títular: " + _titular
                + ", Saldo: R$" + Saldo;
        }

        public string Titular { 
            get { return _titular; } 
            set {
                if (_titular != null && _titular.Length > 1) { 
                    _titular = value; 
                } 
            } 
        }
    }
    
    
    class Program {
        static void Main(string[] args) {

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o títular da conta: ");
            string titular = Console.ReadLine();

            char op;
            double valor = 0.0;
            sbyte exit = 1;

            while (exit == 1) {
                Console.Write("Haverá depósito inicial? (s/n) ");
                op = char.Parse(Console.ReadLine());

                if (op == 's' || op == 'S') {
                    Console.Write("Entre o valor de depósito inicial: ");
                    valor = double.Parse(Console.ReadLine());
                    exit = 0;
                } else if (op == 'n' || op == 'N') {
                    exit = 0;
                } else {
                    Console.WriteLine("Character inválido! Tente novamente.");
                }
            }

            Console.WriteLine(" ");
            Conta c = new Conta(numero, titular, valor);
            Console.WriteLine(c);

            Console.WriteLine(" ");
            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            c.Deposito(valor);
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            c.Saque(valor);
            Console.WriteLine(c);
        }
    }
}
