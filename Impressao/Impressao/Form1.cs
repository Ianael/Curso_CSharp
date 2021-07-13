using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressao {
    public partial class Form1 : Form {
        int x, y, altura, largura, nLinhas, pagina, nPaginas;

        public Form1() {
            InitializeComponent();
            pagina = 0;
            nPaginas = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e) {
            x = 50;
            y = 50;
            altura = printDocument.DefaultPageSettings.Bounds.Height;
            largura = printDocument.DefaultPageSettings.Bounds.Width;
            nLinhas = 0;

            if (printDialog.ShowDialog() != DialogResult.Cancel) {
                altura = printDocument.DefaultPageSettings.Bounds.Height;
                largura = printDocument.DefaultPageSettings.Bounds.Width;
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e) {
            if (pagina < nPaginas) {
                printPreviewControl.StartPage = ++pagina;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e) {
            if (pagina > 0) {
                printPreviewControl.StartPage = --pagina;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e) {
            x = 50;
            y = 50;
            altura = printDocument.DefaultPageSettings.Bounds.Height;
            largura = printDocument.DefaultPageSettings.Bounds.Width;
            nLinhas = 0;

            printPreviewControl.Document = printDocument;
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e) {
            #region Part 1
            //Desenhar o documento a ser impresso
            /*string texto = "Trabalhando com impressão.";
            Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Point pontoInicial = new Point(100, 50);

            e.Graphics.DrawString(texto, letra, Brushes.Black, pontoInicial);*/

            #endregion

            #region Part 2
            /*int x = printDocument.DefaultPageSettings.Bounds.X;
            int y = printDocument.DefaultPageSettings.Bounds.Y;
            int altura = printDocument.DefaultPageSettings.Bounds.Height;
            int largura = printDocument.DefaultPageSettings.Bounds.Width;

            string texto = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Repudiandae sed dolore veritatis...";
            Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Point pontoInicial = new Point(100, 50);
            Rectangle areaTexto = new Rectangle(x+50, y+100, largura-100, altura-200); // 50/100/200 margem

            e.Graphics.DrawString(texto, letra, Brushes.Black, areaTexto);
            e.Graphics.DrawRectangle(new Pen(Color.Red, 5), areaTexto);*/
            #endregion

            #region Part 3
            //Várias páginas
            Font letra = new Font("TimesNewRoman", 12, FontStyle.Bold, GraphicsUnit.Point);

            List<string> linhas = new List<string>() {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25",
                "26",
                "27",
                "28",
                "29",
                "30",
                "31",
                "32",
                "33",
                "34",
                "35",
                "36",
                "37",
                "38",
                "39",
                "40",
                "41",
                "42",
                "43",
                "44",
                "45",
                "46",
                "47",
                "48",
                "49",
                "50"
            };

            while (nLinhas < linhas.Count) {
                e.Graphics.DrawString(linhas[nLinhas], letra, Brushes.Black, new Point(x, y));
                
                y += 30;
                nLinhas++;

                if (y >= altura - 50) {
                    //Muda pag
                    y = 50;
                    e.HasMorePages = true;
                    nPaginas++;
                    break;
                }
            }

            #endregion
        }

        private void btnVisualizarPadrao_Click(object sender, EventArgs e) {
            x = 50;
            y = 50;
            altura = printDocument.DefaultPageSettings.Bounds.Height;
            largura = printDocument.DefaultPageSettings.Bounds.Width;
            nLinhas = 0;

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}
