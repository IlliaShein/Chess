using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class Queen : ChessPiece
    {

        public Queen(FigureColor color)
            : base(color )
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (board.colorBoard[row, col] == CellColor.RED)
            {
                Turn.changeColor();
                board.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == color)
            {
                board.PaintBoardStandartColors(e, gameField);
                board.PaintCellInYellow(gameField, e);
                FiguresLogicProcessing.QueenLogicProcessing(e, gameField, board);
            }
        }
    }
}
