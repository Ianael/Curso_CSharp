using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleErros {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e) {
            try {
                int[] num = { 10, 20, 30, 40, 50 };

                string res = String.Empty;
                for (int i = 0; i < 15; i++) {                    
                    res += num[i] + " ";
                }

                lblResult.Text = res;

            } catch (Exception ex) {
                lblResult.Text = "Erro: " + ex.Message;
            } finally {                                  //Sempre é executado
                MessageBox.Show("Operação finalizada.");
            }
        }
    }
}
