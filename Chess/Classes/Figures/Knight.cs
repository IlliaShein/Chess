using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    class Knight : PluralChessPiece
    {
        public Knight(FigureColor color, int number)
            : base(color, number)
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            GameLogic.PaintCellInYellow(gameField, e, board);
            GameLogic.KnightLogicProcessing(e, gameField, board);
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
