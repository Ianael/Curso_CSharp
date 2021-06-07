using System;
using Xadrez_Console.Tabuleiro;
using Xadrez_Console.Xadrez;

namespace Xadrez_Console.Tabuleiro {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaXadrez partida = new PartidaXadrez();

                while (!partida.Terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine("Origem: ");
                    Posicao origem = Tela.LerPosicao().ToPosicao();

                }
                Tela.imprimirTabuleiro(partida.tab);
            
            } catch (TabuleiroException e) {
                Console.WriteLine("ERROR: " + e.Message);
            } catch (Exception e) {
                Console.WriteLine("ERROR: " + e.Message);
            }
        }
    }
}
