using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Bispo : Peca {
        public Bispo(MeuTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "B";
        }
    }
}