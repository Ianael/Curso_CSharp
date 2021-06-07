using System;
using System.Collections.Generic;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Tabuleiro {
    class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; set; }
        public MeuTabuleiro Tab { get; protected set; }

        public Peca(MeuTabuleiro tab, Cor cor) {
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tab = tab;
        }

        public void IncrementarMovimentos() {
            QtdMovimentos++;
        }
    }
}
