using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    class Queen : ChessPiece
    {

        public Queen(FigureColor color)
            : base(color )
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            GameLogic.PaintCellInYellow(gameField, e, board);
            GameLogic.QueenLogicProcessing(e, gameField, board);
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
