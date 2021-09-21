using System;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Arquivos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            string pasta = @"E:\";
            string arquivo = @"teste.txt";

            bool res = File.Exists(pasta + arquivo);

            //lblResult.Text = res.ToString();
            //File.Delete(pasta + arquivo);
            if (!res) {
                File.Create(pasta + arquivo).Close();
                lblResult.Text = "Arquivo Criado";
            } else {
                lblResult.Text = "O Arquivo já existe";
            }

            if (res) {
                File.Copy(pasta+arquivo, pasta+"copia.txt", true);
                lblResult.Text = "Arquivo Copiado";
                
                File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.UTF8);

                lblResult.Text = File.GetCreationTime(pasta + arquivo).ToString();

                lblResult.Text += " " + File.ReadAllText(pasta+arquivo, Encoding.UTF8);
                
            } else {
                lblResult.Text = "Arquivo não existe";
            }

            if (File.Exists(pasta + "mover.txt")) {
                File.Move(pasta + "mover.txt", pasta + "MoveTest\\Movido.txt"); //Move o arquivo para pasta destino
            } 
        }
    }
}
