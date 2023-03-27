using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    class Rook : PluralChessPiece
    {
        public Rook(FigureColor color, int number)
            : base(color, number)
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            GameLogic.PaintCellInYellow(gameField, e, board);
            GameLogic.RockLogicProcessing(e, gameField, board);
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
