using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class Pawn : PluralChessPiece
    {
        public bool firstTurn;

        public Pawn(FigureColor color , int number)
            : base(color , number)
        {
            firstTurn = true;
        }
        public override void Select(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (ChessBoard.ChessBoard.colorBoard[row,col] == CellColor.RED)
            {
                Turn.changeColor();
                ChessBoard.ChessBoard.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == color)
            {
                ChessBoard.ChessBoard.PaintBoardStandartColors(e, gameField);
                ChessBoard.ChessBoard.PaintCellInYellow(gameField, e);

                if (ChessBoard.ChessBoard.IfBoardTurning() == true ||  color == FigureColor.WHITE)
                {
                    FiguresLogicProcessing.WhitePawnLogicProcessing(e, gameField);
                }
                else //this.color == FigureColor.BLACK
                {
                    FiguresLogicProcessing.BlackPawnLogicProcessing(e, gameField);
                }
            }
        }
    }
}
