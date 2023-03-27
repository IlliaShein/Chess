using Chess.Classes.Figures;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.ChessBoard
{
    
    public class ChessBoard
    {
        public ChessPiece[,] board;
        public CellColor[,] colorBoard;

        public ChessBoard()
        {
            board = new ChessPiece[8, 8];
            colorBoard = new CellColor[8, 8];

            FillBoard();
            FillColorBoard();
        }

        public void PaintBoardStandartColors(MouseButtonEventArgs e, Grid GameField)
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

        public void ClearColorBoard()
        {
            for (int i = 0; i < colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < colorBoard.GetLength(1); j++)
                {
                    colorBoard[i, j] = CellColor.EMPTY;
                }
            }
        }

        public void PaintCellInYellow(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
              .Cast<UIElement>()
              .First(e => Grid.GetRow(e) == row && Grid.GetColumn(e) == col) as Border;


            cell.Background = ChessColors.GetYellowRGB();
            colorBoard[row, col] = CellColor.YELLOW;
        }

        public void MoveFigure(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            if (board[fromRow, fromCol] is Pawn)
            {
                ((Pawn)board[fromRow, fromCol]).firstTurn = false;
            }
            else if(board[fromRow, fromCol] is King)
            {
                ((King)board[fromRow, fromCol]).firstTurn = false;
            }

            board[toRow, toCol] = board[fromRow, fromCol];
            board[fromRow, fromCol] = null;

            Image image = GameField.Children
             .Cast<UIElement>()
             .FirstOrDefault(e => e is Image && Grid.GetRow(e) == fromRow && Grid.GetColumn(e) == fromCol) as Image;

            Grid.SetRow(image, toRow);
            Grid.SetColumn(image, toCol);
            PaintBoardStandartColors(e, GameField);
        }

        public void PlaceOneFigureOnAnother(MouseButtonEventArgs e, Grid GameField, int toRow, int toCol, int fromRow, int fromCol)
        {
            if (board[fromRow, fromCol] is Pawn)
            {
                ((Pawn)board[fromRow, fromCol]).firstTurn = false;
            }
            else if (board[fromRow, fromCol] is King)
            {
                ((King)board[fromRow, fromCol]).firstTurn = false;
            }

            board[toRow, toCol] = board[fromRow, fromCol];
            board[fromRow, fromCol] = null;

            Image attakedImage = GameField.Children
             .Cast<UIElement>()
             .FirstOrDefault(e => e is Image && Grid.GetRow(e) == toRow && Grid.GetColumn(e) == toCol) as Image;

            GameField.Children.Remove(attakedImage);

            Image image = GameField.Children
             .Cast<UIElement>()
             .FirstOrDefault(e => e is Image && Grid.GetRow(e) == fromRow && Grid.GetColumn(e) == fromCol) as Image;

            Grid.SetRow(image, toRow);
            Grid.SetColumn(image, toCol);
            PaintBoardStandartColors(e, GameField);
        }

        public void AttackFigure(MouseButtonEventArgs e, Grid gameField, int row , int col)
        {
            for (int i = 0; i < colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < colorBoard.GetLength(1); j++)
                {
                    if (colorBoard[i, j] == CellColor.YELLOW)
                    {
                        PlaceOneFigureOnAnother(e, gameField, row, col, i, j);
                    }
                }
            }
        }

        private void FillBoard()
        {
            board[0,0] = new Rook(FigureColor.BLACK,0);
            board[0, 7] = new Rook(FigureColor.BLACK, 1);

            board[0, 1] = new Knight(FigureColor.BLACK, 0);
            board[0, 6] = new Knight(FigureColor.BLACK, 1);

            board[0, 2] = new Bishop(FigureColor.BLACK, 0);
            board[0, 5] = new Bishop(FigureColor.BLACK, 1);

            board[0, 3] = new King(FigureColor.BLACK);
            board[0, 4] = new Queen(FigureColor.BLACK);

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

            board[7, 3] = new King(FigureColor.WHITE);
            board[7, 4] = new Queen(FigureColor.WHITE);
        }

        private void FillColorBoard()
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
