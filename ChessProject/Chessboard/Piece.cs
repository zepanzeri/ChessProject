﻿namespace Chessboard
{
    public class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int Movement { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Color = color;
            Board = board;
            Movement = 0;
        }
        
        
    }
}
