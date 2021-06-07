using System;
using Xadrez_Console.Tabuleiro;

namespace Xadrez_Console.Tabuleiro {
    class TabuleiroException : Exception{
        public TabuleiroException(string msg) : base(msg) { }
    }
}
