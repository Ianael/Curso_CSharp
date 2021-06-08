using System;
using System.Collections.Generic;
using System.Text;

namespace Xadrez_Console.Tabuleiro {
    class MeuTabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public MeuTabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna) {
            return Pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca p, Posicao pos) {
            if (ExistePeca(pos)) {
                throw new TabuleiroException("Já existe uma PEÇA nessa posição!");
            }
            
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;        
        }

        public Peca RetirarPeca(Posicao pos) {
            if (peca(pos) == null) {
                return null;
            }

            Peca aux = peca(pos);
            aux.Posicao = null;
            Pecas[pos.Linha, pos.Coluna] = null;
            return aux;
        }

        public bool PosicaoValida(Posicao pos) {
            if (pos.Linha < 0 || pos.Linha >= Linhas || pos.Coluna < 0 || pos.Coluna >= Colunas) {
                return false;
            }
            return true;
        }

        public bool ExistePeca(Posicao pos) {
            PosicaoValida(pos);
            return peca(pos) != null;
        }
    }
}
