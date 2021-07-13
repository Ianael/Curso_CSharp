using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFileDialog_Test {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e) {

            openFileDialog.Filter = "Imagens|*.png;*.jpg|Icone|*.ico|Todos os Arquivos|*.*"; //Sem espaços!!!

            if (openFileDialog.ShowDialog() != DialogResult.Cancel) {
                foreach (string item in openFileDialog.FileNames) { //FileNames -> Seleciona vários
                    listBox.Items.Add(item);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            saveFileDialog.Filter = "Text|*.txt|Documento|*.doc|Portável|*.pdf";
            if (saveFileDialog.ShowDialog() != DialogResult.Cancel) {
                lblArquvio.Text = saveFileDialog.FileName; //FileName -> Apenas 1 arquivo
            }
        }
    }
}
