using Chess.Classes;
using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess
{
    public partial class MainWindow : Window
    {
        ChessBoard Board = new ChessBoard();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void WhitePawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 0 , e);
        }

        private void WhitePawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 1, e);
        }

        private void WhitePawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 2, e);
        }

        private void WhitePawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 3, e);
        }

        private void WhitePawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 4, e);
        }

        private void WhitePawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 5, e);
        }

        private void WhitePawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 6, e);
        }

        private void WhitePawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.WHITE, 7, e);
        }

        private void BlackPawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 0, e);
        }

        private void BlackPawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 1, e);
        }

        private void BlackPawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 2, e);
        }

        private void BlackPawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 3, e);
        }

        private void BlackPawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 4, e);
        }

        private void BlackPawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 5, e);
        }

        private void BlackPawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 6, e);
        }

        private void BlackPawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Pawn>(FigureColor.BLACK, 7, e);
        }
        private void WhiteKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Knight>(FigureColor.WHITE, 0, e);
        }

        private void WhiteKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Knight>(FigureColor.WHITE, 1, e);
        }
        private void BlackKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Knight>(FigureColor.BLACK, 0, e);
        }

        private void BlackKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Knight>(FigureColor.BLACK, 1, e);
        }

        private void WhiteBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Bishop>(FigureColor.WHITE, 0, e);
        }

        private void WhiteBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Bishop>(FigureColor.WHITE, 1, e);
        }

        private void BlackBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Bishop>(FigureColor.BLACK, 0, e);
        }

        private void BlackBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Bishop>(FigureColor.BLACK, 1, e);
        }

        private void WhiteRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Rook>(FigureColor.WHITE, 0, e);
        }
        private void WhiteRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Rook>(FigureColor.WHITE, 1, e);
        }

        private void BlackRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Rook>(FigureColor.BLACK, 0, e);
        }

        private void BlackRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Rook>(FigureColor.BLACK, 1, e);
        }

        private void WhiteQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Queen>(FigureColor.WHITE, e);
        }

        private void BlackQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<Queen>(FigureColor.BLACK, e);
        }
        private void WhiteKing_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<King>(FigureColor.WHITE, e);
        }

        private void BlackKing_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SelectPiece<King>(FigureColor.BLACK, e);
        }

        private void GameField_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (Board.colorBoard[row, col] == CellColor.GREEN || Board.colorBoard[row, col] == CellColor.RED)
            {
                for (int i = 0; i < Board.colorBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < Board.colorBoard.GetLength(1); j++)
                    {
                        if(Board.colorBoard[i,j] == CellColor.YELLOW)
                        {
                            Board.board[row, col] = Board.board[i, j];
                            Board.board[i, j] = null;

                            Image image = GameField.Children
                             .Cast<UIElement>()
                             .FirstOrDefault(e => e is Image && Grid.GetRow(e) == i && Grid.GetColumn(e) == j) as Image;

                            Grid.SetRow(image, row);
                            Grid.SetColumn(image, col);
                            PaintBoardStandartColors(e);
                        }
                    }
                }
            }
            else if(Board.colorBoard[row, col] != CellColor.YELLOW)
            {
                PaintBoardStandartColors(e);
            }

        }

        private void PaintBoardStandartColors(MouseButtonEventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Border cell = GameField.Children
                    .Cast<UIElement>()
                    .First(e => Grid.GetRow(e) == i && Grid.GetColumn(e) == j) as Border;

                    if(i%2 == 0)
                    {
                        if(j%2 == 0)
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
        private void ClearColorBoard()
        {
            for (int i = 0; i < Board.colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < Board.colorBoard.GetLength(1); j++)
                {
                    Board.colorBoard[i, j] = CellColor.EMPTY;
                }
            }        
        }

        private void SelectPiece<T>(FigureColor color, int number, MouseButtonEventArgs e) where T : PluralChessPiece
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
        private void SelectPiece<T>(FigureColor color, MouseButtonEventArgs e) where T : ChessPiece
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



    }
}
