using System;
using Chessboard;
using Display;
using Chess;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board(8, 8);
           // b.placePiece(new Position)
            Show.ShowBoard(b);
        }
    }
}
