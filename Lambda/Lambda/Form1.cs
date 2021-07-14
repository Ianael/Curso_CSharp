using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Lambda {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            //Expressão lambda que tem uma expressão como corpo:
            // (input - parameters) => expression

            //Instrução lambda que tem um bloco de instrução como corpo:
            // (input - parameters) => { < sequence - of - statements > }

            //SEM LAMBDA
            /*Func<int, int> square = quadrado;
            lblResult.Text = "O resultado é " + square(5);*/

            //COM LAMBDA
            Func<int, int> square = x => x * x;
            //lblResult.Text = "O resultado é " + square(5);

            Expression<Func<int, int>> ex = x => x + x;
            //lblResult.Text = "O resultado é " + ex.ToString();

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * x);
            //lblResult.Text = string.Join(" ", squaredNumbers);

            Action<string> greet = name => {
                string greeting = $"Hello {name}!";
                lblResult.Text = greeting;
            };
            //greet("Ia");

            Action line = () => Console.WriteLine();
            Console.WriteLine("Greatings");
            line();
            Console.WriteLine("Artagan");

            Func<int, int, bool> testForEquality = (x, y) => x == y;
            lblResult.Text = testForEquality(10, 15).ToString();

        }

        int quadrado(int x) {
            return x * x;
        }
    }
}
