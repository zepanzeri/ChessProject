namespace Chessboard
{
    public class Board
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] pieces;

        public Board(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            pieces = new Piece[rows, columns];
        }

        public Piece piece(int row,int column)
        {
            return pieces[row, column];
        }

        public Piece piece(Position pos)
        {
            return pieces[pos.Row, pos.Column];
        }

        public void placePiece(Piece p, Position pos){
          pieces[pos.Row, pos.Column] = p;
          p.Position = pos;
        }

        public bool validPosition(Position pos)
        {
            if (pos.Row < 0 || pos.Row >= Rows || pos.Column < 0 ||
                pos.Column >= Columns)
                return false;
            
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!validPosition(pos))
                throw new ChessBoardException("Invalid position.");
        }

        public bool existPiece(Position pos)
        {
            validatePosition(pos);
            return piece(pos) != null;
        }
    }
}
