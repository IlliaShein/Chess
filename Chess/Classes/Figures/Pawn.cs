using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class Pawn : PluralChessPiece
    {
        public bool FirstTurn;

        public Pawn(FigureColor color , int number)
            : base(color , number)
        {
            FirstTurn = true;
        }
        public override void Select(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (ChessBoard.ChessBoard.ColorBoard[row,col] == CellColor.RED)
            {
                Turn.changeColor();
                ChessBoard.ChessBoard.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == Сolor)
            {
                ChessBoard.ChessBoard.PaintBoardStandartColors(e, gameField);
                ChessBoard.ChessBoard.PaintCellInYellow(gameField, e);

                if (ChessBoard.ChessBoard.IfBoardTurning() == true || Сolor == FigureColor.WHITE)
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
