using System;
using System.Windows.Forms;

namespace ProjectAsync {
    public partial class Form1 : Form {
        public static ListBox lstRes;

        public Form1() {
            InitializeComponent();
            lstRes = listaResultado;
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            listaResultado.Items.Add("Evento do botão foi iniciado : clique aqui");

            Exemplo obj = new Exemplo();
            obj.Task_LongaDuracao();

            listaResultado.Items.Add("Evento do botão foi concluído");
        }

        private async void btnExecAsync_Click(object sender, EventArgs e) {
            listaResultado.Items.Add("Evento do botão foi iniciado : clique aqui");

            ExemploAsync obj = new ExemploAsync();
            await obj.Task_LongaDuracao_Async();

            listaResultado.Items.Add("Evento do botão foi concluído");
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            listaResultado.Items.Clear();
        }
    }
}
