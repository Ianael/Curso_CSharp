using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Thread_Task {
    public partial class Threads : Form {
        
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Threads() {
            InitializeComponent();

            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e) {
            MessageBox.Show("Principal!");
        }

        private void btnContador_Click(object sender, EventArgs e) {
            if (!t.IsAlive) {
                t.Start();
            }
        }

        private void Tarefa() {
            while (true) {
                //lblConsole.Text = DateTime.Now.Second.ToString(); --> função abaixo faz isso com segurança (necessário para threads)
                //DefinirValorPropriedade(lblConsole, "Text", DateTime.Now.Second.ToString());
                lblConsole.Invoke(new Action(() => lblConsole.Text = DateTime.Now.Second.ToString())); //Action -> 'delegate' anonimo
            }
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor) {
            if (controle.InvokeRequired) {
                AtualizarControle del = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(del, new object[] { controle, propriedade, valor });
            } else {
                Type type = controle.GetType();
                PropertyInfo[] props = type.GetProperties();

                foreach (PropertyInfo p in props) {
                    if (p.Name.ToUpper() == propriedade.ToUpper()) {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }

        /*private void Tarefa() { //Funciona em Console, Forms precisa utilizar Invoke
            for (int i = 0; i < 10; i++) {
                lblConsole.Text += "Tarefa executada\n";
                Thread.Sleep(200);
            }
        }

        private void btnStart_Click(object sender, EventArgs e) {
            Thread t = new Thread(new ThreadStart(Tarefa));

            t.IsBackground = true;
            t.Start();
            t.Join(); //"junta" as threads, bloqueia a principal até que a secundária finalize suas tarefas


            for (int i = 0; i < 10; i++) {
                lblConsole.Text += "Principal\n";
                Thread.Sleep(100);
            }
        }*/
    }
}
