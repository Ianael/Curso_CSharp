using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TransferirArquivoCliente {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            FTCliente.labelMensagem = lblStatus;
        }

        private void btnEnviar_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtIP.Text.Trim()) 
                || string.IsNullOrEmpty(txtPorta.Value.ToString())
                || txtArquivo.Text == ("Clique para selecionar o arquivo...")) 
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Dados inválidos";
                return;
            }

            FTCliente.EnderocoIP = txtIP.Text;
            FTCliente.PortaHost = (int)txtPorta.Value;

            try {
                Task.Factory.StartNew(() => {
                    FTCliente.EnviarArquivo(txtArquivo.Text);
                });
            } catch (Exception ex) {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Erro: " + ex.Message;
            }
        }

        private void txtArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Enviar arquivo";

            if (dialog.ShowDialog() == DialogResult.OK) {
                txtArquivo.Text = dialog.FileName;
            }
        }
    }
}
