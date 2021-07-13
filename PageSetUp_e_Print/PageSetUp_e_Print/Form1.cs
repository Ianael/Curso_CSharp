using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PageSetUp_e_Print {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnConfig_Click(object sender, EventArgs e) {
            pageSetup.PageSettings = new PageSettings();
            pageSetup.PrinterSettings = new PrinterSettings();
            
            if(pageSetup.ShowDialog() != DialogResult.Cancel){
                printDocument.Print();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
            if (printDialog.ShowDialog() != DialogResult.Cancel) {
                printDocument.Print();
            }         
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
            string txt = txtPrint.Text;
            Font letra = new Font("Arial", 20, FontStyle.Regular);
            Brush pincel = new SolidBrush(Color.Black);
            e.Graphics.DrawString(txt, letra, pincel, new PointF(50, 50));
        }

        private void btnVisualizar_Click(object sender, EventArgs e) {
            printPreviewControl.Document = printDocument;
        }
    }
}
