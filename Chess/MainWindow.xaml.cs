using Chess.Classes;
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
        public FiguresBoard board = new FiguresBoard();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WhitePawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void WhitePawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.WhitePawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn0_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }

        private void BlackPawn7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BlackPawnLogicProcessing(e, GameField, board);
        }
        private void WhiteKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KnightLogicProcessing(e, GameField, board);
        }

        private void WhiteKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KnightLogicProcessing(e, GameField, board);
        }
        private void BlackKnight1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KnightLogicProcessing(e, GameField, board);
        }

        private void BlackKnight2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KnightLogicProcessing(e, GameField, board);
        }

        private void WhiteBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BishopLogicProcessing(e, GameField, board);
        }

        private void WhiteBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BishopLogicProcessing(e, GameField, board);
        }

        private void BlackBishop1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BishopLogicProcessing(e, GameField, board);
        }

        private void BlackBishop2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.BishopLogicProcessing(e, GameField, board);
        }

        private void WhiteRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.RockLogicProcessing(e, GameField, board);
        }
        private void WhiteRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.RockLogicProcessing(e, GameField, board);
        }

        private void BlackRock1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.RockLogicProcessing(e, GameField, board);
        }

        private void BlackRock2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.RockLogicProcessing(e, GameField, board);
        }

        private void WhiteQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.QueenLogicProcessing(e, GameField, board);
        }

        private void BlackQueen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.QueenLogicProcessing(e, GameField, board);
        }
        private void WhiteKing_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KingLogicProcessing(e, GameField, board);
        }

        private void BlackKing_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            GameLogic.PaintCellInYellow(GameField, e, board);
            GameLogic.KingLogicProcessing(e, GameField, board);
        }

        private void GameField_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (board.ColorsBoard[row, col] == CellColor.GREEN || board.ColorsBoard[row, col] == CellColor.RED)
            {
                string figureName = GetFigureNameFromPosition();
                MoveFigure(e, figureName);
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
            for (int i = 0; i < board.ColorsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.ColorsBoard.GetLength(1); j++)
                {
                    board.ColorsBoard[i, j] = CellColor.EMPTY;
                }
            }        
        }
        private string GetFigureNameFromPosition()
        {
            Figure figure = GetChoosenFigure();

            if(figure.color == FigureColor.WHITE)
            {
                return "White" + NormalizeFigureName(figure.name); 
            }
            else // figure.color == FigureColor.BLACK
            {
                return "Black" + NormalizeFigureName(figure.name);
            }
        }

        private Figure GetChoosenFigure()
        {
            Figure figure = null;

            for (int i = 0; i < board.figuresBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.figuresBoard.GetLength(1); j++)
                {
                    if (board.ColorsBoard[i, j] == CellColor.YELLOW)
                    {
                        figure = board.figuresBoard[i, j];
                    }
                }
            }

            return figure;
        }

        private string NormalizeFigureName(FigureName figureName)
        {
            string normalizedName = Convert.ToString(figureName);
            normalizedName = normalizedName[0] + normalizedName.Substring(1).ToLower();

            return normalizedName;
        }

        private void MoveFigure(MouseButtonEventArgs e , string figureName)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Image image = GameField.Children
                .Cast<UIElement>()
                .FirstOrDefault(e => e is Image && ((Image)e).Name == figureName) as Image;

            Grid.SetRow(image, row);
            Grid.SetColumn(image, col);

            string name = figureName.Substring(5).ToUpper();
            bool found = false;
            for (int i = 0; i < board.figuresBoard.GetLength(0); i++)
            {
                for (int j = 0; j < board.figuresBoard.GetLength(1); j++)
                {
                    if(board.figuresBoard[i, j] != null 
                        && Convert.ToString(board.figuresBoard[i, j].name) == name)
                    {
                        if(figureName[0] != Convert.ToString(board.figuresBoard[i, j].color)[0])
                        {
                            continue;
                        }

                        board.figuresBoard[row, col] = new Figure(board.figuresBoard[i, j]);
                        board.figuresBoard[row, col].startPosition = false;
                        board.figuresBoard[i, j] = null;

                        found = true;
                        break;
                    }                 
                }
                if (found)
                {
                    break;
                }
            }


        }
    }
}
