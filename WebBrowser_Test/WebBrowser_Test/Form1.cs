using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e) {
            string url = txtURL.Text;
            browser.Navigate("http://" + url);
        }

        private void btnAvancar_Click(object sender, EventArgs e) {
            browser.GoForward();
        }

        private void btnVoltar_Click(object sender, EventArgs e) {
            browser.GoBack();
        }
    }
}
