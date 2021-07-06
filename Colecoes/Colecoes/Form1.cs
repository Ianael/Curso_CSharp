using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colecoes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            pnChoice.Visible = false;
        }

        void fadeOut(object sender, EventArgs e) {
            if (Opacity <= 0) { //check if opacity is 0
                timerFade.Stop();    //if it is, we stop the timer
                Close();
            } else {
                Opacity -= 0.02;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnClose.Height;
            pnChoice.Top = btnClose.Top;

            timerFade.Tick += new EventHandler(fadeOut);  //this calls the fade out function
            timerFade.Start();
        }

        private void btnLista_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnLista.Height;
            pnChoice.Top = btnLista.Top;

            listBox.Items.Clear();

            string[] vect = new string[] { "Eduardo", "Arthur", "Angelo" };

            List<string> nomes = new List<string>();

            nomes.Add("Lucas");
            nomes.Add("João");
            nomes.Add("Anna");

            listBox.Items.Add(nomes[1]);
            listBox.Items.AddRange(vect);
        }

        //Não permite itens iguais
        private void btnHashSet_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnHashSet.Height;
            pnChoice.Top = btnHashSet.Top;

            listBox.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>() {
                "Carro", "Moto", "Caminhão", "Bicicleta", "Helicóptero", "Barco", "Lancha"
            };

            foreach (string item in veiculos) {
                listBox.Items.Add(item);
            }
        }

        //Elementos podem repetir, mas chave não
        private void btnDictionary_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnDictionary.Height;
            pnChoice.Top = btnDictionary.Top;

            listBox.Items.Clear();

            Dictionary<int, string> alunos = new Dictionary<int, string>() {
                {0, "Joe"},
                {1, "Ellie"},
                {2, "Suzenne"},
                {3, "Danny"},
                {4, "Dinna"},
                {5, "Danny"},
            };

            alunos.Add(6, "Emelly");

            foreach (KeyValuePair<int, string> item in alunos) {
                listBox.Items.Add(item);
                //listBox.Items.Add(item.Value);
                //listBox.Items.Add(item.Key);
            }
        }

        private void btnQueue_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnQueue.Height;
            pnChoice.Top = btnQueue.Top;

            listBox.Items.Clear();

            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Banana");
            fila.Enqueue("Abacaxi");
            fila.Enqueue("Tangerina");
            fila.Enqueue("Melancia");

            MessageBox.Show("Primeiro item da fila: " + fila.Peek()); //Pega primeiro valor sem removelo da fila

            for (int i = 0; i < fila.Count; i++) {
                listBox.Items.Add(fila.Dequeue());
                i--;
            }
        }

        private void btnStack_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnStack.Height;
            pnChoice.Top = btnStack.Top;

            listBox.Items.Clear();

            Stack<string> pilha = new Stack<string>();

            pilha.Push("d20");
            pilha.Push("d12");
            pilha.Push("d10");
            pilha.Push("d8");
            pilha.Push("d6");
            pilha.Push("d4");

            MessageBox.Show("Elemento no topo: " + pilha.Peek());

            foreach (string item in pilha) {
                listBox.Items.Add(item); //Remove itens pilha.Pop();
            }
        }

        //Não pode ter chaves iguais, ordena por chave
        private void btnSortedList_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnSortedList.Height;
            pnChoice.Top = btnSortedList.Top;

            listBox.Items.Clear();

            SortedList<int, string> alunos = new SortedList<int, string>() {
                {27, "Danny"},
                {10, "Gabriel"},
                {17, "Arthur"},
                {21, "Carl"}
            };

            alunos.Add(23, "Pietro");

            foreach (KeyValuePair<int, string> item in alunos) { //alunos.Reverse()
                listBox.Items.Add("(" + item.Key + ") " + item.Value);
            }
        }

        //SortedList usa menos memória, SortedDictionary realiza inserções/exclusões mais rápido
        private void btnSortedDictionary_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnSortedDictionary.Height;
            pnChoice.Top = btnSortedDictionary.Top;

            listBox.Items.Clear();

            SortedDictionary<int, string> alunos = new SortedDictionary<int, string>() {
                {2778, "Danny"},
                {1046, "Gabe"},
                {1798, "Orn"},
                {2113, "Kenny"}
            };

            alunos.Add(2348, "Pedro");

            foreach (KeyValuePair<int, string> item in alunos) { //alunos.Reverse()
                listBox.Items.Add("{" + item.Key + "} " + item.Value);
            }
        }

        private void btnSortedSet_Click(object sender, EventArgs e) {
            pnChoice.Visible = true;
            pnChoice.Height = btnSortedSet.Height;
            pnChoice.Top = btnSortedSet.Top;

            listBox.Items.Clear();

            SortedSet<string> nomes = new SortedSet<string>(){ 
                "Hunter", "Gandalf", "Ademar", "Mark", "David"
            };

            foreach (string nome in nomes) {
                listBox.Items.Add(nome);
            }
        }
    }
}

