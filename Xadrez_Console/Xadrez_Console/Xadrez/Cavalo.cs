using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Cavalo : Peca {
        public Cavalo(MeuTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "C";
        }
    }
}
