using System;

namespace Chessboard
{
    public class ChessBoardException : Exception
    {
        public ChessBoardException(string msg) : base(msg)
        {
        }
    }
}