using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Chess
{
    public static class GameLogic
    {
        public static void SelectPiece<T>(FigureColor color, int number, MouseButtonEventArgs e, ChessBoard Board, Grid GameField) where T : PluralChessPiece
        {
            foreach (ChessPiece figure in Board.board)
            {
                if (figure is T && ((T)figure).color == color && ((T)figure).number == number)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e, Board);
                }
            }
        }

        public static void SelectPiece<T>(FigureColor color, MouseButtonEventArgs e , ChessBoard Board, Grid GameField) where T : ChessPiece
        {
            foreach (ChessPiece figure in Board.board)
            {
                if (figure is T && ((T)figure).color == color)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e, Board);
                }
            }
        }

        public static void GameFieldClickLogicProcessing(MouseButtonEventArgs e, ChessBoard Board, Grid GameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (Board.colorBoard[row, col] == CellColor.GREEN || Board.colorBoard[row, col] == CellColor.RED)
            {
                for (int i = 0; i < Board.colorBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < Board.colorBoard.GetLength(1); j++)
                    {
                        if (Board.colorBoard[i, j] == CellColor.YELLOW)
                        {
                             Board.MoveFigure(e, GameField, row, col, i, j);
                        }
                    }
                }
            }
            else if (Board.colorBoard[row, col] != CellColor.YELLOW)
            {
                Board.PaintBoardStandartColors(e,GameField);
            }
        }
    }
}
