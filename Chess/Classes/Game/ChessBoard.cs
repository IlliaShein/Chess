using Chess.Classes.Figures;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.ChessBoard
{
    
    public static class ChessBoard
    {
        private static bool _showAvailableTurns = true;
        private static bool _turnBoardAroundAfterEachTurn = false;
        public static ChessPiece[,] Board = new ChessPiece[8, 9];
        public static CellColor[,] ColorBoard = new CellColor[8, 8];

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
            return _showAvailableTurns;
        }

        public static bool IfBoardTurning()
        {
            return _turnBoardAroundAfterEachTurn;
        }

        public static void ChangeTurningMode(bool boardTurns)
        {
            _turnBoardAroundAfterEachTurn = boardTurns;
        }

        public static void SetShowingAvailableTurns(bool show)
        {
            _showAvailableTurns = show;
        }

        public static void ClearBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Board[i, j] = null;
                }
            }
        }

        public static void ClearColorBoard()
        {
            for (int i = 0; i < ColorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ColorBoard.GetLength(1); j++)
                {
                    ColorBoard[i, j] = CellColor.EMPTY;
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
            ColorBoard[row, col] = CellColor.YELLOW;
        }

        public static void CastlingProcessing(MouseButtonEventArgs e , Grid gameField , bool firstTurn, int row, int col, FigureColor color)
        {
            if (firstTurn && Board[row, col + 1] == null
              && Board[row, col + 2] == null
              && Board[row, col + 3] != null
              && Board[row, col + 3] is Rook
              && Board[row, col + 3].Сolor == color)
            {
                PaintCellInBlue(gameField, e, row, col + 3);
            }
            if (firstTurn && Board[row, col - 1] == null
                && Board[row, col - 2] == null
                && Board[row, col - 3] == null
                && Board[row, col - 4] != null
                && Board[row, col - 4] is Rook
                && Board[row, col - 4].Сolor == color)
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

            ColorBoard[row, col] = CellColor.BLUE;
        }

        public static void MoveFigure(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            CheckPawnAndKingFirstTurn(fromRow, fromCol);

            Board[toRow, toCol] = Board[fromRow, fromCol];
            Board[fromRow, fromCol] = null;

            MoveImage(e, GameField, fromRow, fromCol, toRow, toCol);
        }

        private static void CheckPawnAndKingFirstTurn(int row, int col)
        {
            if (Board[row, col] is Pawn)
            {
                ((Pawn)Board[row, col]).FirstTurn = false;
            }
            else if (Board[row, col] is King)
            {
                ((King)Board[row, col]).FirstTurn = false;
            }
        }
        public static void PlaceOneFigureOnThePlaceOfAnother(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            CheckPawnAndKingFirstTurn(fromRow, fromCol);

            Board[toRow, toCol] = Board[fromRow, fromCol];
            Board[fromRow, fromCol] = null;

            RemoveFigure(GameField, toRow, toCol);

            MoveImage(e, GameField, fromRow, fromCol, toRow, toCol);

            SwitchSides(e, GameField);
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
            for (int i = 0; i < ColorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ColorBoard.GetLength(1); j++)
                {
                    if (ColorBoard[i, j] == CellColor.YELLOW)
                    {
                        PlaceOneFigureOnThePlaceOfAnother(e, gameField, row, col, i, j);
                    }
                }
            }
        }

        public static void FillBoard()
        {
            Board[0,0] = new Rook(FigureColor.BLACK,0);
            Board[0, 7] = new Rook(FigureColor.BLACK, 1);

            Board[0, 1] = new Knight(FigureColor.BLACK, 0);
            Board[0, 6] = new Knight(FigureColor.BLACK, 1);

            Board[0, 2] = new Bishop(FigureColor.BLACK, 0);
            Board[0, 5] = new Bishop(FigureColor.BLACK, 1);

            Board[0, 4] = new King(FigureColor.BLACK);
            Board[0, 3] = new Queen(FigureColor.BLACK);

            for (int i = 0; i < 8; i++)
            {
                Board[1, i] = new Pawn(FigureColor.BLACK,i);
                Board[6, i] = new Pawn(FigureColor.WHITE, i);
            }

            Board[7, 0] = new Rook(FigureColor.WHITE, 0);
            Board[7, 7] = new Rook(FigureColor.WHITE, 1);

            Board[7, 1] = new Knight(FigureColor.WHITE, 0);
            Board[7, 6] = new Knight(FigureColor.WHITE, 1);

            Board[7, 2] = new Bishop(FigureColor.WHITE, 0);
            Board[7, 5] = new Bishop(FigureColor.WHITE, 1);

            Board[7, 4] = new King(FigureColor.WHITE);
            Board[7, 3] = new Queen(FigureColor.WHITE);
        }

        public static void FillColorBoard()
        {
            for (int i = 0; i < ColorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ColorBoard.GetLength(1); j++)
                {
                    ColorBoard[i, j] = CellColor.EMPTY;
                }
            }
        }

        public static void SwitchSides(MouseButtonEventArgs e, Grid GameField)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(Board[i, j] == null && Board[7 - i, j] != null)
                    {
                        MoveFigureWithoutLogic(e, GameField, i, j, 7 - i, j);
                    }
                    else if(Board[i, j] != null && Board[7 - i, j] == null)
                    {
                        MoveFigureWithoutLogic(e, GameField, 7 - i, j, i, j);
                    }
                    else if(Board[i, j] != null && Board[7 - i, j] != null)
                    {
                        MoveFigureWithoutLogic(e, GameField, 0, 8, 7 - i, j);

                        MoveFigureWithoutLogic(e, GameField, 7 - i, j, i, j);

                        MoveFigureWithoutLogic(e, GameField, i, j, 0, 8);
                    }
                }
            }
        }

        private static void MoveFigureWithoutLogic(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {

            Board[toRow, toCol] = Board[fromRow, fromCol];
            Board[fromRow, fromCol] = null;

            MoveImage(e, GameField, fromRow, fromCol, toRow, toCol);
        }
    }
}
