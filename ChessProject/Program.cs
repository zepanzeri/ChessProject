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
            ChessPosition pos = new ChessPosition('c','7');
            Console.WriteLine(pos);
        }
    }
}
