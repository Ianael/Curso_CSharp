using System;
using System.Collections.Generic;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Torre : Peca {
        public Torre(MeuTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "T";
        }
    }
}