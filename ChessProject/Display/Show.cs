using System;
using Chessboard;

namespace Display
{
    class Show
    {
        public static void ShowBoard(Board board)
        {
            for(int i = 0; i < board.Rows; i++)
            {
                for (int j = 0; j < board.Columns; j++)
                {
                    if (board.piece(i, j) == null)
                        Console.Write("- ");
                    else
                        Console.Write(board.piece(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
