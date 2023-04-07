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
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (board.colorBoard[row,col] == CellColor.RED)
            {
                Turn.changeColor();
                board.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == color)
            {
                board.PaintBoardStandartColors(e, gameField);
                board.PaintCellInYellow(gameField, e);

                if (color == FigureColor.WHITE)
                {
                    FiguresLogicProcessing.WhitePawnLogicProcessing(e, gameField, board);
                }
                else //this.color == FigureColor.BLACK
                {
                    FiguresLogicProcessing.BlackPawnLogicProcessing(e, gameField, board);
                }
            }
        }
    }
}
