using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Chess
{
    public static class GameLogic
    {
        public static void SelectPiece<T>(FigureColor color, int number, MouseButtonEventArgs e, Grid GameField) where T : PluralChessPiece
        {
            foreach (ChessPiece figure in ChessBoard.board)
            {
                if (figure is T && ((T)figure).color == color && ((T)figure).number == number)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e);
                }
            }
        }

        public static void SelectPiece<T>(FigureColor color, MouseButtonEventArgs e, Grid GameField) where T : ChessPiece
        {
            foreach (ChessPiece figure in ChessBoard.board)
            {
                if (figure is T && ((T)figure).color == color)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e);
                }
            }
        }

        public static void GameFieldClickLogicProcessing(MouseButtonEventArgs e, Grid GameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if(col > 7 || row > 7)
            {
                return; 
            }

            if (ChessBoard.colorBoard[row, col] == CellColor.GREEN) //|| Board.colorBoard[row, col] == CellColor.RED
            {
                for (int i = 0; i < ChessBoard.colorBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < ChessBoard.colorBoard.GetLength(1); j++)
                    {
                        if (ChessBoard.colorBoard[i, j] == CellColor.YELLOW)
                        {
                            Turn.changeColor();
                            ChessBoard.MoveFigure(e, GameField, row, col, i, j);
                        }
                    }
                }
            }
            else if (ChessBoard.colorBoard[row, col] != CellColor.YELLOW)
            {
                ChessBoard.PaintBoardStandartColors(e,GameField);
            }
        }
    }
}
