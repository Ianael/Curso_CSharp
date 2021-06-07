using System;
using System.Collections.Generic;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console {
    class Tela {
        public static void imprimirTabuleiro(MeuTabuleiro tab){
            for (int i=0; i < tab.Linhas; i++) {
                Console.Write(8-i + " ");
                for (int j=0; j<tab.Colunas; j++) {
                    if (tab.peca(i, j) == null) {
                        Console.Write("- ");
                    } else {
                        Tela.ImprimirPeca(tab.peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void ImprimirPeca(Peca peca) {
            if (peca.Cor == Cor.Branca) {
                Console.Write(peca);
            } else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }

        public static PosicaoXadrez LerPosicao() {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "")

            return new PosicaoXadrez(coluna, linha);
        }
    }
}
