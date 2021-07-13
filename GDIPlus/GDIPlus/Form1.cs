using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnDesenhar_Click(object sender, EventArgs e) {
            Bitmap folha = new Bitmap(pict.Width, pict.Height);

            Graphics artista = Graphics.FromImage(folha);

            artista.Clear(Color.White);

            Pen lapis = new Pen(Color.Black, 5);
            Brush pincel = new SolidBrush(Color.Blue);
            Brush pincel2 = new SolidBrush(Color.ForestGreen);
            Pen lapis2 = new Pen(pincel, 15);
            Pen lapis3 = new Pen(Color.Red, 3);
            Pen lapis4 = new Pen(Color.Orange);
            
            #region Linhas
            Point pontoX = new Point(100, 350);
            Point pontoY = new Point(700, 350);

            artista.DrawLine(lapis, pontoX, pontoY);

            pontoX = new Point(50, 200);
            pontoY = new Point(500, 200);
            artista.DrawLine(lapis2, pontoX, pontoY);

            Point[] pontos = {
                new Point(50, 50),
                new Point(150, 100),
                new Point(250, 50),
                new Point(100, 50),
                new Point(85, 240)
            };
            artista.DrawLines(lapis, pontos);
            #endregion

            #region Retângulos

            artista.DrawRectangle(lapis3, 400, 150, 300, 200);
            Rectangle rect1 = new Rectangle(401, 151, 150, 150);
            Rectangle rect2 = new Rectangle(465, 225, 150, 150);

            Brush pincelGradiente = new LinearGradientBrush(rect2, Color.Cyan, Color.Magenta, 45);

            artista.FillRectangle(Brushes.ForestGreen, rect1);
            artista.FillRectangle(pincelGradiente, rect2);
            //artista.DrawRectangles(lapis3, rects[]);

            #endregion

            #region Circulos e Elipses

            Rectangle rect = new Rectangle(100, 100, 500, 300);
            Rectangle rect3 = new Rectangle(450, 50, 150, 150);
            artista.DrawEllipse(lapis, rect);
            artista.DrawEllipse(lapis3, rect3);

            Brush pincelElipse = new LinearGradientBrush(rect3, Color.Red, Color.Magenta, 90);
            artista.FillEllipse(pincelElipse, rect3);
            artista.DrawRectangle(lapis3, rect3); //A Elipse utiliza a area do retangulo para ser gerada

            #endregion

            #region Poligonos

            Point[] points2 = {
                new Point(150, 100),
                new Point(350, 200),
                new Point(300, 250)
            };

            artista.DrawPolygon(lapis, points2);
            artista.FillPolygon(Brushes.Yellow, points2);

            #endregion

            #region Curvas

            Point[] pontos3 = { 
                new Point(360, 50),
                new Point(400, 100),
                new Point(650, 200)
            };
            artista.DrawCurve(lapis, pontos3, 1.5f);
            artista.DrawClosedCurve(lapis, pontos3, 1.5f, FillMode.Alternate);
            Brush pincelCurva = new LinearGradientBrush(rect3, Color.Yellow, Color.Orange, 180);
            artista.FillClosedCurve(pincelCurva, pontos3);
            #endregion

            #region Arcos

            Rectangle rect4 = new Rectangle(200, 300, 300, 250);
            artista.DrawArc(lapis4, rect4, 45f, 270f);

            #endregion

            #region Baziers

            Point p1 = new Point(50, 300);
            Point p2 = new Point(200, 400);
            Point p3 = new Point(400, 100);
            Point p4 = new Point(500, 200);
            
            artista.DrawBezier(lapis, p1, p2, p3, p4);

            #endregion
            
            #region Gráfico Pie

            Rectangle rect5 = new Rectangle(50, 50, 300, 300);
            //artista.DrawPie(lapis, rect5, 0, 90);
            artista.FillPie(Brushes.Orange, rect5, 0, 90);

            #endregion

            #region Path

            GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);

            graphicsPath.AddEllipse(new RectangleF(10, 380, 100, 50)); 
            graphicsPath.AddEllipse(new RectangleF(50, 380, 100, 50)); 
            artista.DrawPath(lapis, graphicsPath);
            artista.FillPath(Brushes.Aquamarine, graphicsPath);

            #endregion

            #region Strings

            string texto = "Ianael Bianchessi";
            Font fonte = new Font("TimesNewRoman", 12, FontStyle.Italic | FontStyle.Bold);
            Point p = new Point(620, 425);

            artista.DrawString(texto, fonte, Brushes.Black, p); //Para quebra de linha adicione um retangulo para delimitar a área

            //Mudar alinhamento
            /*StringFormat alinhamento = new StringFormat();
            alinhamento.Alignment = StringAlignment.Center;
            alinhamento.LineAlignment = StringAlignment.Center;

            artista.DrawString(texto, fonte, Brushes.Black, p, alinhamento);*/

            #endregion

            #region Imagens
            Image img = Image.FromFile(Application.StartupPath + @"\imagens\tavern.jpg");

            //Seleciona toda a img
            //Rectangle origem = new Rectangle(0, 0, img.Width, img.Height); 
            //Rectangle destino = new Rectangle(100, 50, img.Width/3, img.Height/3);

            //Rectangle destino = new Rectangle(0, 0, pict.Width, pict.Height); //Preenche tela
            
            //Parte da img
            Rectangle origem = new Rectangle(195, 440, 587, 639); 
            Rectangle destino = new Rectangle(625, 0, 587/4, 639/4);

            artista.DrawImage(img, destino, origem, GraphicsUnit.Pixel);

            #endregion

            pict.BackgroundImage = folha;
            folha.Save(@"E:\csharp\GDIPlus\desenho.jpg", ImageFormat.Jpeg);
        }
    }
}
