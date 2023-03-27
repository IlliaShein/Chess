using System;
using System.Windows.Controls;
using System.Windows.Input;

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
            board.PaintBoardStandartColors(e, gameField);
            board.PaintCellInYellow(gameField, e);
            if (this.color == FigureColor.WHITE)
            {
                FiguresLogicProcessing.WhitePawnLogicProcessing(e, gameField, board);
            }
            else //this.color == FigureColor.BLACK
            {
                FiguresLogicProcessing.BlackPawnLogicProcessing(e, gameField, board);
            }  
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
