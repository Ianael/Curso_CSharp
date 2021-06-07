using System;

namespace Ex_Estoque {
    public class Produto {
        private string _nome;
        public double Preco {get; private set;}
        public int Qnt {get; private set;}

        public Produto(string nome, double preco, int qnt) {
            _nome = nome;
            Preco = preco;
            Qnt = qnt;
        }
        /*
        public Produto() {

        }

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;      
            Qnt = 0;
        }
        */
        //Properties
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Qnt;
        }
        public void AdicionarProdutos(int x) {
            int ant = Qnt;
            Qnt += x;
            Console.WriteLine("Produtos adicionados com sucesso! De {0} para {1}", ant, Qnt);
        }

        public void RemoverProdutos(int x) {
            int ant = Qnt;
            Qnt -= x;
            Console.WriteLine("Produtos removidos com sucesso! De {0} para {1}", ant, Qnt);
        }

        public override string ToString() {
            return "Nome: " + Nome
                + ", Preço: R$" + Preco
                + ", Unidades: " + Qnt
                + ", Valor total em estoque: R$" + ValorTotalEmEstoque();
        }
    }

    class Program {
        static void Main(string[] args) {
            //Produto p = new Produto("Banana", 1.5, 10);
            //Console.WriteLine(p);

            /*
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int qnt = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qnt);
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("");
            Console.Write("Quantos produtos deseja adicionar ao estoque: ");
            int ad = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(ad);

            Console.WriteLine("");
            Console.Write("Quantos produtos deseja remover do estoque: ");
            int re = int.Parse(Console.ReadLine());
            p.RemoverProdutos(re);

            Console.WriteLine("");
            Console.WriteLine("Dados do Produto: " + p);

            Produto p2 = new Produto {
                Nome = "TV",
                Preco = 500.0,
                Qnt = 20
            };
            */

    }
}


        }
    }
}
