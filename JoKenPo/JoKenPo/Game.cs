using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo {
    class Game {
        public enum Resultado{
            Vitoria,
            Derrota,
            Empate
        }

        public static Image[] imagens = {
            Image.FromFile(@"imagens\jo_pedra.png"),
            Image.FromFile(@"imagens\ken_papel.png"),
            Image.FromFile(@"imagens\po_tesoura.png")
        };

        public Image ImgPC { get; private set; }

        public Image ImgPlayer { get; private set; }

        public Resultado Jogar(int player) {
            int pc = JogadaPC();
            
            ImgPlayer = imagens[player];
            ImgPC = imagens[pc];

            if (player == pc) {
                return Resultado.Empate;
            }else if ((player == 0 && pc == 2) || (player == 1 && pc == 0) || (player == 2 && pc == 1)) {
                return Resultado.Vitoria;
            } else {
                return Resultado.Derrota;
            }            
        }

        private int JogadaPC() {
            int mil = DateTime.Now.Millisecond;

            if (mil < 333) {
                return 0;
            } else if (mil < 666) {
                return 1;
            } else {
                return 2;
            }
        }
    }
}
