using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialog_Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCor_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() != DialogResult.Cancel) {
                lblCor.BackColor = colorDialog.Color;
                btnCor.BackColor = colorDialog.Color;
            }
        }

        private void btnDir_Click(object sender, EventArgs e) {
            if (folderDialog.ShowDialog() != DialogResult.Cancel){
                lblCor.Text = folderDialog.SelectedPath;
            }
        }

        private void btnFonte_Click(object sender, EventArgs e) {
            if (fontDialog.ShowDialog() != DialogResult.Cancel) {
                lblCor.Font = fontDialog.Font;
                btnFonte.Font = fontDialog.Font;
            }
        }
    }
}
