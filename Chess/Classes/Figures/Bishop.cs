using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    class Bishop : PluralChessPiece
    {
        public Bishop(FigureColor color , int number)
           : base(color,  number)
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            board.PaintCellInYellow(gameField, e);
            FiguresLogicProcessing.BishopLogicProcessing(e, gameField, board);
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
