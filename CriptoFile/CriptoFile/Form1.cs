using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CriptoFile {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            Criptografia.cspp = new CspParameters();
            Criptografia.EncrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Encrypt\";
            Criptografia.DecrFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Decrypt\";
            Criptografia.SrcFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnEncryptFile_Click(object sender, EventArgs e) {
            if (Criptografia.rsa == null) { //Não iniciado
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Chave não definida.";
            } else {
                //Escolha do arquivo p/ criptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.SrcFolder;

                if (dialog.ShowDialog() == DialogResult.OK) {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);

                    //Passa nome do arquivo com caminho
                    string name = fInfo.FullName;
                    lblTexto.Text = Criptografia.EncryptFile(name);                    
                }
            }
        }

        private void btnDecryptFile_Click(object sender, EventArgs e) {
            if (Criptografia.rsa == null) { //Não iniciado
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Chave não definida.";
            } else {
                //Escolha do arquivo p/ descriptografar
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.InitialDirectory = Criptografia.EncrFolder;

                if (dialog.ShowDialog() == DialogResult.OK) {
                    string fName = dialog.FileName;
                    FileInfo fInfo = new FileInfo(fName);

                    //Passa nome do arquivo com caminho
                    string name = fInfo.Name;
                    lblTexto.Text = Criptografia.DecryptFile(name);
                }
            }
        }

        private void btnCreateAsmKeys_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtKey.Text.Trim())) {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Insira um valor para definir a chave pública.";
                lblTexto.Focus();
                return;
            }

            Criptografia.keyName = txtKey.Text;
            lblTexto.ForeColor = Color.DarkBlue;
            lblTexto.Text = Criptografia.CreateAsmKeys();
        }

        private void btnExportPublicKeys_Click(object sender, EventArgs e) {
            if (Criptografia.ExportPublicKey()) {
                lblTexto.ForeColor = Color.DarkBlue;
                lblTexto.Text = "Chave pública exportada.";
            } else {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Chave pública não exportada.";
            }
        }

        private void btnImportPublicKey_Click(object sender, EventArgs e) {
            Criptografia.keyName = "Pública";
            lblTexto.ForeColor = Color.DarkBlue;
            lblTexto.Text = Criptografia.ImportPublicKey();
        }

        private void btnGetPrivateKey_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtKey.Text.Trim())) {
                lblTexto.ForeColor = Color.Red;
                lblTexto.Text = "Insira um valor para definir a chave privada.";
                txtKey.Focus();
                return;
            }

            Criptografia.keyName = txtKey.Text;
            lblTexto.ForeColor = Color.DarkBlue;

            lblTexto.Text = Criptografia.GetPrivateKey();
        }
    }
}
