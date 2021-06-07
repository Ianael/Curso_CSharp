using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Xadrez {
    class PartidaXadrez {
        public MeuTabuleiro tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; };

        public PartidaXadrez() {
            tab = new MeuTabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino) {
            Peca p = tab.RetirarPeca(origem);
            p.IncrementarMovimentos();
            Peca PecaCapturada = tab.RetirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void ColocarPecas() {
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('a', 1).ToPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('b', 1).ToPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('c', 1).ToPosicao());
            tab.ColocarPeca(new Dama(tab, Cor.Branca), new PosicaoXadrez('d', 1).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Branca), new PosicaoXadrez('e', 1).ToPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Branca), new PosicaoXadrez('f', 1).ToPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Branca), new PosicaoXadrez('g', 1).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Branca), new PosicaoXadrez('h', 1).ToPosicao());

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('a', 8).ToPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('b', 8).ToPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('c', 8).ToPosicao());
            tab.ColocarPeca(new Dama(tab, Cor.Preta), new PosicaoXadrez('d', 8).ToPosicao());
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new PosicaoXadrez('e', 8).ToPosicao());
            tab.ColocarPeca(new Bispo(tab, Cor.Preta), new PosicaoXadrez('f', 8).ToPosicao());
            tab.ColocarPeca(new Cavalo(tab, Cor.Preta), new PosicaoXadrez('g', 8).ToPosicao());
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new PosicaoXadrez('h', 8).ToPosicao());
        }
    }
}
