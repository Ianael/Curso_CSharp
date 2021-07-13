using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatServer {
    public partial class Form1 : Form {
        private delegate void AtualizaStatusCallback(string strMensagem);

        bool conectado = false;
        
        public Form1() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            if (conectado) {
                Application.Exit();
                return;
            }

            if (txtIP.Text == string.Empty) {
                MessageBox.Show("Informe o endereço IP.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIP.Focus();
                return;
            }

            try {
                //Analisa IP do servidor informado
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);
                int portaHost = (int)txtPorta.Value;

                //Cria instância do objeto ChatServidor
                Servidor mainServidor = new Servidor(enderecoIP, portaHost);

                //Vincula o tratamento de evento StatusChanged a mainServidor_StatusChanged
                Servidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                //Inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                //Mostra a iniciação do atendimento p/ conexões
                listaLog.Items.Add("Servidor ativo, aguardando usuários se conectarem...");
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
            } catch (Exception ex) {
                listaLog.Items.Add("Erro de conexão: " + ex.Message);
                listaLog.SetSelected(listaLog.Items.Count - 1, true);
                return;
            }

            conectado = true;
            txtIP.Enabled = false;
            txtPorta.Enabled = false;
            btnStart.ForeColor = Color.Red;
            btnStart.Text = "Sair";
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e) {
            //Chama método que atualiza formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] {e.EventMessage});
        }

        private void AtualizaStatus(string strMensagem) {
            listaLog.Items.Add(strMensagem);
            listaLog.SetSelected(listaLog.Items.Count-1, true);
        }
    }
}
