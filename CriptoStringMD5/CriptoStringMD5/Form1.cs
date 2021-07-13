using System;
using System.Windows.Forms;

namespace CriptoStringMD5 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCriptografar_Click(object sender, EventArgs e) {
            CriptoMD5 md5 = new CriptoMD5();
            txtSaida.Text = md5.RetornarMD5(txtEntrada.Text);
        }

        private void btnComparar_Click(object sender, EventArgs e) {
            string senhaBanco = "0B782FBB5DCF455F51D818E811234664";
            string senhaEntrada = txtEntrada.Text;

            CriptoMD5 md5 = new CriptoMD5();
            bool resultado = md5.CompararMD5(senhaEntrada, senhaBanco);

            if (resultado) {
                lblResult.Text = "Senhas Iguais";
            } else {
                lblResult.Text = "Senhas Diferentes";
            }

        }
    }
}
