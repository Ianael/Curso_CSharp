
namespace Xadrez_Console.Tabuleiro {
    abstract class Peca {
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

        public void DecrementarMovimentos() {
            QtdMovimentos--;
        }

        public bool ExisteMovimentosPossiveis(){
            bool[,] mat = MovimetosPossiveis();

            for(int i=0; i < Tab.Linhas; i++) {
                for (int j = 0; j < Tab.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos) {
            return MovimetosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimetosPossiveis();
    }
}
