using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceRoll {
    public partial class Form1 : Form {
        Random roll = new Random(); //Baixa variação de valores
        Random r = new Random(DateTime.Now.Millisecond); 
        int yourRoll;

        public Form1() {
            InitializeComponent();
            lblCrit.Visible = false;

            var pos = this.PointToScreen(lblRoll.Location);
            pos = pictDice.PointToClient(pos);
            lblRoll.Parent = pictDice;
            lblRoll.Location = pos;
            lblRoll.BackColor = Color.Transparent;
        }

        private void btnD4_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d4.png");
            //yourRoll = roll.Next(1, 5); //Entre 1 e 4, último número é excluso
            yourRoll = Convert.ToInt32(r.NextDouble() * 3) + 1;
            lblRoll.Text = yourRoll.ToString();
        }

        private void btnD6_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d6.png");
            //yourRoll = roll.Next(1, 7);
            yourRoll = Convert.ToInt32(r.NextDouble() * 5) + 1;
            lblRoll.Text = yourRoll.ToString();
        }

        private void btnD8_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d8.png");
            //yourRoll = roll.Next(1, 9);
            yourRoll = Convert.ToInt32(r.NextDouble() * 7) + 1;
            lblRoll.Text = yourRoll.ToString();
        }

        private void btnD10_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d10.png");
            //yourRoll = roll.Next(1, 11);
            yourRoll = Convert.ToInt32(r.NextDouble() * 9) + 1;
            lblRoll.Text = yourRoll.ToString();
        }

        private void btnD12_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d12.png");
            //yourRoll = roll.Next(1, 13);
            yourRoll = Convert.ToInt32(r.NextDouble() * 11) + 1;
            lblRoll.Text = yourRoll.ToString();
        }

        private void btnD20_Click(object sender, EventArgs e) {
            ResetRoll();
            pictDice.BackgroundImage = Image.FromFile(@"imagens\d20.png");
            //yourRoll = roll.Next(1, 21);
            yourRoll = Convert.ToInt32(r.NextDouble() * 19) + 1;

            if (yourRoll == 1) {
                lblCrit.Visible = true;
                lblCrit.Text = "Falha Crítica!";
                lblCrit.ForeColor = Color.Red;
                lblRoll.ForeColor = Color.OrangeRed;
            }else if (yourRoll == 20) {
                lblCrit.Visible = true;
                lblCrit.Text = "Crítico!!!";
                lblCrit.ForeColor = Color.Green;
                lblRoll.ForeColor = Color.Green;
            }

            lblRoll.Text = yourRoll.ToString();
        }

        private void ResetRoll() {
            lblCrit.Visible = false;
            lblRoll.ForeColor = Color.Black;
        }
    }
}
