using Chess.Classes.Figures;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.ChessBoard
{
    
    public static class ChessBoard
    {
        private static bool ShowAvailableTurns = true;
        public static ChessPiece[,] board = new ChessPiece[8, 8];
        public static CellColor[,] colorBoard = new CellColor[8, 8];

        public static void PaintBoardStandartColors(MouseButtonEventArgs e, Grid GameField)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Border cell = GameField.Children
                    .Cast<UIElement>()
                    .First(e => Grid.GetRow(e) == i && Grid.GetColumn(e) == j) as Border;

                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            cell.Background = ChessColors.GetStandartLightRGB();
                        }
                        else
                        {
                            cell.Background = ChessColors.GetStandartDarkRGB();
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            cell.Background = ChessColors.GetStandartDarkRGB();
                        }
                        else
                        {
                            cell.Background = ChessColors.GetStandartLightRGB();
                        }
                    }
                }
            }
            ClearColorBoard();
        }

        public static bool IfShowingAvailableTurns()
        {
            return ShowAvailableTurns;
        }

        public static void SetShowingAvailableTurns(bool show)
        {
            ShowAvailableTurns = show;
        }

        public static void ClearBoard()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = null;
                }
            }
        }

        public static void ClearColorBoard()
        {
            for (int i = 0; i < colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < colorBoard.GetLength(1); j++)
                {
                    colorBoard[i, j] = CellColor.EMPTY;
                }
            }
        }

        public static void PaintCellInYellow(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
              .Cast<UIElement>()
              .First(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == col) as Border;

            if (row % 2 == 0)
            {
                if (col % 2 == 0)
                {
                    cell.Background = ChessColors.GetYellowLightRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetYellowDarkRGB();
                }
            }
            else
            {
                if (col % 2 == 0)
                {
                    cell.Background = ChessColors.GetYellowDarkRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetYellowLightRGB();
                }
            }
            colorBoard[row, col] = CellColor.YELLOW;
        }

        public static void CastlingProcessing(MouseButtonEventArgs e , Grid gameField , bool firstTurn, int row, int col, FigureColor color)
        {
            if (firstTurn && board[row, col + 1] == null
              && board[row, col + 2] == null
              && board[row, col + 3] != null
              && board[row, col + 3] is Rook
              && board[row, col + 3].color == color)
            {
                PaintCellInBlue(gameField, e, row, col + 3);
            }
            if (firstTurn && board[row, col - 1] == null
                && board[row, col - 2] == null
                && board[row, col - 3] == null
                && board[row, col - 4] != null
                && board[row, col - 4] is Rook
                && board[row, col - 4].color == color)
            {
                PaintCellInBlue(gameField, e, row, col - 4);
            }
        }

        public static void PaintCellInBlue(Grid gameField, MouseButtonEventArgs e, int row , int col)
        {
            Border cell = gameField.Children
              .Cast<UIElement>()
              .First(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == col) as Border;

            if (row % 2 == 0)
            {
                if (col % 2 == 0)
                {
                    cell.Background = ChessColors.GetBlueLightRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetBlueDarkRGB();
                }
            }
            else
            {
                if (col % 2 == 0)
                {
                    cell.Background = ChessColors.GetBlueDarkRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetBlueLightRGB();
                }
            }

            colorBoard[row, col] = CellColor.BLUE;
        }

        public static void MoveFigure(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            CheckPawnAndKingFirstTurn(fromRow, fromCol);

            GameNote.AddTurn(GameField, board, toRow, toCol, fromRow, fromCol);

            board[toRow, toCol] = board[fromRow, fromCol];
            board[fromRow, fromCol] = null;

            MoveImage(e, GameField, fromRow, fromCol, toRow, toCol);
        }

        private static void CheckPawnAndKingFirstTurn(int row, int col)
        {
            if (board[row, col] is Pawn)
            {
                ((Pawn)board[row, col]).firstTurn = false;
            }
            else if (board[row, col] is King)
            {
                ((King)board[row, col]).firstTurn = false;
            }
        }

        public static void PlaceOneFigureOnThePlaceOfAnother(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            CheckPawnAndKingFirstTurn(fromRow, fromCol);

            board[toRow, toCol] = board[fromRow, fromCol];
            board[fromRow, fromCol] = null;

            RemoveFigure(GameField, toRow, toCol);

            MoveImage(e, GameField, fromRow, fromCol, toRow, toCol);
        }

        private static void MoveImage(MouseButtonEventArgs e , Grid GameField, int fromRow, int fromCol, int toRow, int toCol)
        {
            Image image = GameField.Children
            .Cast<UIElement>()
            .FirstOrDefault(e => e is Image && Grid.GetRow(e) == fromRow && Grid.GetColumn(e) == fromCol) as Image;

            Grid.SetRow(image, toRow);
            Grid.SetColumn(image, toCol);
            PaintBoardStandartColors(e, GameField);
        }

        private static void RemoveFigure(Grid GameField , int row, int col)
        {
            Image attakedImage = GameField.Children
             .Cast<UIElement>()
             .FirstOrDefault(e => e is Image && Grid.GetRow(e) == row && Grid.GetColumn(e) == col) as Image;

            GameField.Children.Remove(attakedImage);
        }

        public static void AttackFigure(MouseButtonEventArgs e, Grid gameField, int row , int col)
        {
            for (int i = 0; i < colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < colorBoard.GetLength(1); j++)
                {
                    if (colorBoard[i, j] == CellColor.YELLOW)
                    {
                        PlaceOneFigureOnThePlaceOfAnother(e, gameField, row, col, i, j);
                    }
                }
            }
        }

        public static void FillBoard()
        {
            board[0,0] = new Rook(FigureColor.BLACK,0);
            board[0, 7] = new Rook(FigureColor.BLACK, 1);

            board[0, 1] = new Knight(FigureColor.BLACK, 0);
            board[0, 6] = new Knight(FigureColor.BLACK, 1);

            board[0, 2] = new Bishop(FigureColor.BLACK, 0);
            board[0, 5] = new Bishop(FigureColor.BLACK, 1);

            board[0, 4] = new King(FigureColor.BLACK);
            board[0, 3] = new Queen(FigureColor.BLACK);

            for (int i = 0; i < 8; i++)
            {
                board[1, i] = new Pawn(FigureColor.BLACK,i);
                board[6, i] = new Pawn(FigureColor.WHITE, i);
            }

            board[7, 0] = new Rook(FigureColor.WHITE, 0);
            board[7, 7] = new Rook(FigureColor.WHITE, 1);

            board[7, 1] = new Knight(FigureColor.WHITE, 0);
            board[7, 6] = new Knight(FigureColor.WHITE, 1);

            board[7, 2] = new Bishop(FigureColor.WHITE, 0);
            board[7, 5] = new Bishop(FigureColor.WHITE, 1);

            board[7, 4] = new King(FigureColor.WHITE);
            board[7, 3] = new Queen(FigureColor.WHITE);
        }

        public static void FillColorBoard()
        {
            for (int i = 0; i < colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < colorBoard.GetLength(1); j++)
                {
                    colorBoard[i, j] = CellColor.EMPTY;
                }
            }
        }
    }
}
