using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graficos {
    public partial class Form1 : Form {
        Dictionary<double, double> valores;
        int contadorX = 0;

        public Form1() {
            InitializeComponent();
            valores = new Dictionary<double, double>();
        }

        private void Form1_Load(object sender, EventArgs e) {
            txtX.Focus();

            for (int i = 0; i < 35; i++) {
                cmbTipoGrafico.Items.Add((SeriesChartType)i);
            }
            for (int i = 0; i < 13; i++) {
                cmbPalletCor.Items.Add((ChartColorPalette)i);
            }
        }

        private void btnInserirValores_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtX.Text) || string.IsNullOrEmpty(txtY.Text)) {
                MessageBox.Show("Os valores X e Y são obrigatórios", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Sobrescreve valores existentes caso já existam
            if (valores.ContainsKey(double.Parse(txtX.Text))) {
                valores[double.Parse(txtX.Text)] = double.Parse(txtY.Text); //Indice é a key - eixo X
            } else {
                valores.Add(double.Parse(txtX.Text), double.Parse(txtY.Text));
            }

            //Ordena valores por X p/ gráfico não regredir se próx valor X for menor
            var items = from valor in valores orderby valor.Key ascending select valor;

            dataValores.Rows.Clear();
            grafico.Series[0].Points.Clear();

            foreach (var item in items) {
                dataValores.Rows.Add(item.Key, item.Value);
                grafico.Series[0].Points.AddXY(item.Key, item.Value);
            }

            grafico.Update();

            txtX.Text = String.Empty;
            txtY.Text = String.Empty;
            txtX.Focus();
        }

        private void dataValores_SelectionChanged(object sender, EventArgs e) {
            txtX.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[0].Value.ToString();
            txtY.Text = dataValores.Rows[dataValores.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            valores.Clear();
            dataValores.Rows.Clear();
            grafico.Series[0].Points.Clear();
            contadorX = 0;
            txtX.Text = String.Empty;
            txtY.Text = String.Empty;
            txtX.Focus();
        }

        private void cmbTipoGrafico_SelectedIndexChanged(object sender, EventArgs e) {
            grafico.Series[0].ChartType = (SeriesChartType)cmbTipoGrafico.SelectedItem;
        }

        private void cmbPalletCor_SelectedIndexChanged(object sender, EventArgs e) {
            grafico.Palette = (ChartColorPalette)cmbPalletCor.SelectedItem;
        }

        private void chkGrafico3D_CheckedChanged(object sender, EventArgs e) {
            grafico.ChartAreas[0].Area3DStyle.Enable3D = chkGrafico3D.Checked;
        }

        private void timer_Tick(object sender, EventArgs e) {
            //Exibe apenas últimos 10 valores
            if (grafico.Series[0].Points.Count() > 10) { 
                grafico.Series[0].Points.RemoveAt(0);
                grafico.Update();
            }

            //Gera y aleatório menor que 1000
            double y = (double)new Random((int)DateTime.Now.Ticks).Next(1000);

            grafico.Series[0].Points.AddXY(contadorX++, y);
            dataValores.Rows.Add(contadorX, y);
            dataValores.CurrentCell = dataValores.Rows[dataValores.Rows.Count - 1].Cells[0];
        }

        private void btnInserirAleatorio_Click(object sender, EventArgs e) {
            timer.Enabled = !timer.Enabled;
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e) {
            //Aceita apenas NÚMEROS, BACKSPACE (8), ENTER (13) e UMA VÍRGULA (44)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44)
                || (txtX.Text.Contains((char)44) && e.KeyChar == (char)44)) {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e) {
            //Aceita apenas NÚMEROS, BACKSPACE (8), ENTER (13) e UMA VÍRGULA (44)
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)13 && e.KeyChar != (char)44)
                || (txtY.Text.Contains((char)44) && e.KeyChar == (char)44)) {
                e.Handled = true;
            }
        }

    }
}
