using Chessboard;

namespace Chess
{
    public class ChessPosition
    {
        public char Column { get; set; }
        public char Row { get; set; }

        public ChessPosition(char column, char row)
        {
            Column = column;
            Row = row;
        }

        public Position toPosition()
        {
            return new Position(8 - Row, Column - 'a');
        }

        public override string ToString()
        {
            return "" + Column + Row;
        }
    }
}