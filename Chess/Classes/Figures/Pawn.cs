using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Chess.Classes.ChessBoard;

namespace Chess.Classes.Figures
{
    class Pawn : PluralChessPiece
    {
        public bool firstTurn;

        public Pawn(FigureColor color , int number)
            : base(color , number)
        {
            firstTurn = true;
        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            if(this.color == FigureColor.WHITE)
            {
                GameLogic.PaintCellInYellow(gameField, e, board);
                GameLogic.WhitePawnLogicProcessing(e, gameField, board);
            }
            else //this.color == FigureColor.BLACK
            {
                GameLogic.PaintCellInYellow(gameField, e, board);
                GameLogic.BlackPawnLogicProcessing(e, gameField, board);
            }  
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
