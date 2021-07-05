using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistLogin {
    public partial class Login : Form {
        public static bool Cancelar = false;
        
        public Login() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            Cancelar = true;
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            if (Cadastro.Login(txtUser.Text, txtPassword.Text)) {
                Cancelar = false;
                Close();
            } else {
                MessageBox.Show("Usuário ou senha incorretos!", "Atenção!", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                
                txtUser.Text = String.Empty;
                txtPassword.Text = String.Empty;

                txtUser.Focus();
            }
        }
    }
}
