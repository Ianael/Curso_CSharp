using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeclasComandos {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Select();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnX_Click(object sender, EventArgs e) {
            lblTexto.Text = "Clicou no botão Tecla X";
        }

        private void btnEnter_Click(object sender, EventArgs e) {
            lblTexto.Text = "Clicou no botão Tecla Enter";
        }

        private void form_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char)97) {
                btnEnter.PerformClick();
                lblTexto.Text += " - Através da tecla 'a'";
            }
        }
    }
}
