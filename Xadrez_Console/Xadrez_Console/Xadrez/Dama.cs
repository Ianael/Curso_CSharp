using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class Dama : Peca {
        public Dama(MeuTabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString() {
            return "D";
        }
    }
}