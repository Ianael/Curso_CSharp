using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer {
    public partial class Form1 : Form {
        Task tarefa;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            txtPasta.Text = FTServer.PastaRecepcaoArquivos;
            FTServer.listaMensagem = listaLogs;
        }

        private void btnConexao_Click(object sender, EventArgs e) {
            try {
                FTServer.EnderocoIP = txtIP.Text;
                FTServer.PortaHost = (int)(txtPorta.Value);

                tarefa = Task.Factory.StartNew(() => {
                    FTServer.IniciarServidor();
                });

            } catch (Exception ex) {
                listaLogs.Invoke(new Action(() => {
                    listaLogs.Items.Add("Erro ao conectar: " + ex);
                    listaLogs.SetSelected(listaLogs.Items.Count-1, true);
                }));
            }
        }

        private void btnParar_Click(object sender, EventArgs e) {
            try {
                Application.Restart(); //Já mata todas as threads
            } catch (Exception ex) {
                listaLogs.Invoke(new Action(() => {
                    listaLogs.Items.Add("Erro ao tentar parar servidor: " + ex);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                }));
            }
        }

        private void txtPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() != DialogResult.Cancel) {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                txtPasta.Text = FTServer.PastaRecepcaoArquivos; 
            }
        }
    }
}
