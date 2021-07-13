using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_1 {
    public partial class Form1 : Form {
        List<string> lista_nomes;
        List<int> lista_numeros;
        Dictionary<string, double> lista_produtos;
        Dictionary<string, string> lista_estados;

        public Form1() {
            InitializeComponent();

            #region Lista de Nomes
            lista_nomes = new List<string>();
            lista_nomes.Add("Gabriel");
            lista_nomes.Add("Angelo");
            lista_nomes.Add("Danny");
            lista_nomes.Add("Arthur");
            lista_nomes.Add("Carlos");
            lista_nomes.Add("Danielle");
            lista_nomes.Add("Thuxs");
            lista_nomes.Add("Logan");
            lista_nomes.Add("Artigas");
            lista_nomes.Add("Flávio");
            lista_nomes.Add("Beatriz");
            lista_nomes.Add("Glória");
            lista_nomes.Add("Maria");
            lista_nomes.Add("Bia");
            lista_nomes.Add("Eduardo");
            lista_nomes.Add("Ianael");
            lista_nomes.Add("Marcio");
            lista_nomes.Add("Lurde");
            lista_nomes.Add("Miguel");
            lista_nomes.Add("Sarah");
            lista_nomes.Add("Saray");
            lista_nomes.Add("Larissa");
            lista_nomes.Add("João");
            lista_nomes.Add("Lucas");
            lista_nomes.Add("Guilherme");
            lista_nomes.Add("Maciel");
            #endregion

            #region Lista Números
            lista_numeros = new List<int>();
            lista_numeros.Add(10);
            lista_numeros.Add(5);
            lista_numeros.Add(8);
            lista_numeros.Add(54);
            lista_numeros.Add(57);
            lista_numeros.Add(2);
            lista_numeros.Add(3);
            lista_numeros.Add(15);
            lista_numeros.Add(12);
            lista_numeros.Add(7);
            #endregion

            #region Lista Produtos
            lista_produtos = new Dictionary<string, double>();
            lista_produtos.Add("Teclado USB", 49.95);
            lista_produtos.Add("Teclado PS2", 45.95);
            lista_produtos.Add("Teclado Gamer", 358.99);
            lista_produtos.Add("Mouse", 29.5);
            lista_produtos.Add("Monitor", 780.85);
            lista_produtos.Add("Memória 16Gb", 700.00);
            lista_produtos.Add("Memória 8Gb", 375.65);
            lista_produtos.Add("Processador", 1250);
            lista_produtos.Add("Placa Mãe", 623.75);
            lista_produtos.Add("Gabinete mATX", 150);
            lista_produtos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista Estados
            lista_estados = new Dictionary<string, string>();
            lista_estados.Add("Rio de Janeiro", "Brasil");
            lista_estados.Add("New York", "Estados Unidos");
            lista_estados.Add("São Paulo", "Brasil");
            lista_estados.Add("Porto", "Portugal");
            lista_estados.Add("Lisboa", "Portugal");
            lista_estados.Add("Bahia", "Brasil");
            lista_estados.Add("Washington", "Estados Unidos");
            lista_estados.Add("Algarve", "Portugal");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            lista.Items.Clear();
            //Metodo Comum
            /*foreach (int num in lista_numeros) {
                if (num % 2 == 0) {
                    lista.Items.Add(num);
                }
            }*/

            //LINQ
            /*IEnumerable<int> pares = from num in lista_numeros where (num%2 == 0) select num;

            foreach (int num in pares) {
                lista.Items.Add(num);
            }*/

            //Pesquisa por nome
            string txt = txtConsulta.Text;
            IEnumerable<string> res2 = from nome in lista_nomes where nome.StartsWith(txt) select nome;

            lista.Items.AddRange(res2.ToArray());
        }

        private void btnWhere_Click(object sender, EventArgs e) {
            lista.Items.Clear();
            string txt = txtConsulta.Text.ToLower();

            var res = from nome in lista_nomes where nome.ToLower().Contains(txt) select nome;

            foreach (var n in res) {
                lista.Items.Add(n);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            lista.Items.Clear();
            string txt = txtConsulta.Text;

            //Numeros
            //var res = from num in lista_numeros orderby num descending select num;

            //Nomes
            //var res = from nome in lista_nomes orderby nome select nome;

            //Produtos
            var res = from produto in lista_produtos orderby produto.Key select produto;

            /*foreach (var x in res) {
                lista.Items.Add(x);
            }*/

            foreach (KeyValuePair<string, double> item in res) {
                lista.Items.Add(item.Key + " - R$" + item.Value);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e) {
            lista.Items.Clear();
            txtConsulta.Text = String.Empty;

            var res = from estado in lista_estados group estado by estado.Value;

            foreach (var grupo in res) {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo) {
                    lista.Items.Add("       " + estado.Key);
                }
            }

        }

        private void btnAgregacao_Click(object sender, EventArgs e) {
            lista.Items.Clear();
            txtConsulta.Text = String.Empty;

            int nCount = lista_nomes.Count();
            int count = (from nome in lista_nomes where nome.StartsWith("G") select nome).Count();
            lista.Items.Add(nCount + " nomes.");
            lista.Items.Add(count + " nomes começam com 'G'.");
            lista.Items.Add(" ");

            double nMedia = lista_numeros.Average();
            var res = from num in lista_numeros where num < 10 select num;
            double media = res.Average();
            int soma1 = lista_numeros.Sum();
            int soma2 = res.Sum();
            lista.Items.Add("Média dos valores da lista_numeros: " + nMedia);
            lista.Items.Add(media + " menores que 10.");
            lista.Items.Add("Soma dos valores: " + soma1);
            lista.Items.Add("Soma dos valores menores que 10: " + soma2);
            lista.Items.Add("Valor menor: " + lista_numeros.Min());
            lista.Items.Add("Valor maior: " + lista_numeros.Max());
            long contagem = lista_numeros.LongCount();

            string maiorNome = lista_nomes.Aggregate((maior, proximo) => {
                if (maior.Length > proximo.Length) {
                    return maior;
                } else {
                    return proximo;
                }
            });

            lista.Items.Add(maiorNome + " é o maior nome da lista.");
        }

        private void btnElemento_Click(object sender, EventArgs e) {
            lista.Items.Clear();

            lista.Items.Add("Valores serão 0 se não existirem!");
            int primeiro = lista_numeros.FirstOrDefault(); //lista_numeros.First();
            int ultimo = lista_numeros.LastOrDefault(); //lista_numeros.Last();
            lista.Items.Add("Primeiro item: " + primeiro);
            lista.Items.Add("Último item: " + ultimo);

            int elemento = lista_numeros.ElementAtOrDefault(3); //lista_numeros.ElementAt(3);
            lista.Items.Add("Elemento na posição 3: " + elemento);

            var consulta = from num in lista_numeros where num > 100 select num;
            int n = consulta.FirstOrDefault();
            lista.Items.Add("Maiores que 100: " + n);

        }

        private void btnLambda_Click(object sender, EventArgs e) {
            lista.Items.Clear();

            //var cons1 = from nome in lista_nomes select nome;             //Normal
            /*var cons1L = lista_nomes.Select(nome => nome);                //Lambda
            lista.Items.AddRange(const1L.ToArray());*/

            //var cons2 = from nome in lista_nomes where nome.StartsWith("G") select nome;
            //var cons2L = lista_nomes.Where(nome => nome.StartsWith("G"));
            //lista.Items.AddRange(const2L.ToArray());

            //var cons3 = from nome in lista_nomes orderby nome select nome;
            //var cons3L = lista_nomes.OrderBy(nome => nome);
            //var cons3L2 = lista_nomes.OrderByDescending(nome => nome);
            //lista.Items.AddRange(cons3L.ToArray());

            /*var cons4 = from estado in lista_estados group estado by estado.Value;
            foreach (var grupo in cons4) {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo) {
                    lista.Items.Add("       " + estado.Key);
                }
            }*/
            var cons4L = lista_estados.GroupBy(estado => estado.Value);
            foreach (var grupo in cons4L) {
                lista.Items.Add(grupo.Key);
                foreach (var estado in grupo) {
                    lista.Items.Add("       " + estado.Key);
                }
            }
        }
    }
}
