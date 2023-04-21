using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class King : ChessPiece
    {
        public bool FirstTurn;
        private bool _wasUnderCheck;

        public King(FigureColor color)
            : base(color)
        {
            FirstTurn = true;
            _wasUnderCheck = false;
        }

        public override void Select(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (ChessBoard.ChessBoard.ColorBoard[row, col] == CellColor.RED)
            {
                Turn.changeColor();
                ChessBoard.ChessBoard.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == Сolor)
            {
                ChessBoard.ChessBoard.PaintBoardStandartColors(e, gameField);
                ChessBoard.ChessBoard.PaintCellInYellow(gameField, e);

                FiguresLogicProcessing.KingLogicProcessing(e, gameField);
                if(!_wasUnderCheck)
                {
                    ChessBoard.ChessBoard.CastlingProcessing(e, gameField, FirstTurn, row, col, Сolor);
                }         
            }
        }
    }
}
