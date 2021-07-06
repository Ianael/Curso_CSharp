using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e) {
            StartGame(0);
        }

        private void btnPapel_Click(object sender, EventArgs e) {
            StartGame(1);
        }

        private void btnTesoura_Click(object sender, EventArgs e) {
            StartGame(2);
        }

        private void StartGame(int opcao) {

            Game duel = new Game();

            switch (duel.Jogar(opcao)) {
                case Game.Resultado.Vitoria:
                    pictResult.BackgroundImage = Image.FromFile(@"imagens\win.jpg");
                    lblResultado.Text = "Vitória";
                    goto default;
                case Game.Resultado.Derrota:
                    pictResult.BackgroundImage = Image.FromFile(@"imagens\lose.png");
                    lblResultado.Text = "Derrota";
                    goto default;
                case Game.Resultado.Empate:
                    pictResult.BackgroundImage = Image.FromFile(@"imagens\draw.png");
                    lblResultado.Text = "Empate";
                    goto default;
                default:
                    pictPlayer.BackgroundImage = duel.ImgPlayer;
                    pictPC.BackgroundImage = duel.ImgPC;
                    break;
            }
        }
    }
}
