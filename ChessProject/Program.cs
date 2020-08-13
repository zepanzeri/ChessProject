using System;
using Chessboard;
using Display;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(8, 8);
            Show.ShowBoard(b);
        }
    }
}
