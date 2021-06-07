using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Peao : Peca {
        public Peao(MeuTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "P";
        }
    }
}
