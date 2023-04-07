using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class King : ChessPiece
    {
        public bool firstTurn;
        bool wasUnderMate;

        public King(FigureColor color)
            : base(color)
        {
            firstTurn = true;
            wasUnderMate = false;
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
                FiguresLogicProcessing.KingLogicProcessing(e, gameField, board);
            }
        }
    }
}
