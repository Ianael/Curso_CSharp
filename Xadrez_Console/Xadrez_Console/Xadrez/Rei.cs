using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez{
    class Rei : Peca {
        public Rei(MeuTabuleiro tab, Cor cor) : base(tab, cor){ }

        public override string ToString() {
            return "R";
        }
    }
}
