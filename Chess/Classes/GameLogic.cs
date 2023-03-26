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
    public static class GameLogic
    {
        public static void PaintCellInYellow(Grid gameField, MouseButtonEventArgs e, FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
              .Cast<UIElement>()
              .First(e => Grid.GetRow(e)  == row && Grid.GetColumn(e)  == col) as Border;

           
            cell.Background = ChessColors.GetYellowRGB();
            board.ColorsBoard[row, col] = CellColor.YELLOW;
        }
        public static void WhitePawnLogicProcessing(MouseButtonEventArgs e, Grid gameField , FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintCell(e, gameField, board, 1, 0);
            if (board.figuresBoard[row,col].startPosition == true)
            {
                PaintCell(e, gameField, board, 2, 0);
            }
        }

        public static void BlackPawnLogicProcessing(MouseButtonEventArgs e, Grid gameField, FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintCell(e, gameField, board, -1, 0);
            if (board.figuresBoard[row, col].startPosition == true)
            {
                PaintCell(e, gameField, board, -2, 0);
            }
        }

        public static void KnightLogicProcessing(MouseButtonEventArgs e, Grid gameField , FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (row > 1)
            {
                if (col != 0)
                {
                    PaintCell(e, gameField, board,  2, 1);
                }
                if (col != 7)
                {
                    PaintCell(e, gameField, board,  2, -1);
                }
            }
            if (col < 6)
            {
                if (row != 0)
                {
                    PaintCell(e, gameField, board, 1, -2);
                }
                if (row != 7)
                {
                    PaintCell(e, gameField, board, -1, -2);
                }
            }
            if (row < 6)
            {
                if (col != 0)
                {
                    PaintCell(e, gameField, board,  -2, 1);
                }
                if (col != 7)
                {
                    PaintCell(e, gameField, board, -2, -1);
                }
            }
            if (col > 1)
            {
                if (row != 0)
                {
                    PaintCell(e, gameField, board, 1, 2);
                }
                if (row != 7)
                {
                    PaintCell(e, gameField, board, -1, 2);
                }
            }
        }

        public static void RockLogicProcessing(MouseButtonEventArgs e, Grid gameField, FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftRockAttackLine(e, gameField, col, board);
            PaintUpRockAttackLine(e, gameField, row, board);
            PaintRightRockAttackLine(e, gameField, col, board);
            PaintDownRockAttackLine(e, gameField, row, board);
        }

        public static void BishopLogicProcessing(MouseButtonEventArgs e, Grid gameField, FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftUpBishopAttackLine(e, gameField, col, row, board);
            PaintRightDownBishopAttackLine(e, gameField, col, row, board);
            PaintLeftDownBishopAttackLine(e, gameField, col, row, board);
            PaintRightUpBishopAttackLine(e, gameField, col, row, board);
        }

        public static void QueenLogicProcessing(MouseButtonEventArgs e, Grid gameField, FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftRockAttackLine(e, gameField, col, board);
            PaintUpRockAttackLine(e, gameField, row, board);
            PaintRightRockAttackLine(e, gameField, col, board);
            PaintDownRockAttackLine(e, gameField, row, board);

            PaintLeftUpBishopAttackLine(e, gameField, col, row, board);
            PaintRightDownBishopAttackLine(e, gameField, col, row, board);
            PaintLeftDownBishopAttackLine(e, gameField, col, row, board);
            PaintRightUpBishopAttackLine(e, gameField, col, row, board);
        }

        public static void KingLogicProcessing(MouseButtonEventArgs e, Grid gameField , FiguresBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if(col - 1 != -1 && row - 1 != -1)
            {
                PaintCell(e, gameField, board, 1, 1);
            }
            if (row - 1 != -1)
            {
                PaintCell(e, gameField, board, 1, 0);
            }
            if (row - 1 != -1 && col+1 != 8)
            {
                PaintCell(e, gameField, board, 1, -1);
            }
            if (col + 1 != 8)
            {
                PaintCell(e, gameField, board, 0, -1);
            }
            if (row + 1 != 8)
            {
                PaintCell(e, gameField, board, -1, 0);
            }
            if (row + 1 != 8 && col + 1 != 8)
            {
                PaintCell(e, gameField, board, -1, -1);
            }
            if (row + 1 != 8 && col - 1 != -1)
            {
                PaintCell(e, gameField, board, -1, 1);
            }
            if (col - 1 != -1)
            {
                PaintCell(e, gameField, board, 0, 1);
            }
        }

        private static void PaintCell(MouseButtonEventArgs e, Grid gameField, FiguresBoard board , int rowOffsetFromChosenCell = 0, int colOffsetFromChosenCell = 0 )
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
                .Cast<UIElement>()
                .First(e => Grid.GetRow(e) + rowOffsetFromChosenCell == row && Grid.GetColumn(e) + colOffsetFromChosenCell == col) as Border;


            if (board.figuresBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] == null)
            {
                ChooseGreenColorForCell(cell, row + rowOffsetFromChosenCell, col + colOffsetFromChosenCell);
                board.ColorsBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] = CellColor.GREEN;
            }
            else if(board.figuresBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)].color != board.figuresBoard[row, col].color)
            {
                ChooseRedColorForCell(cell, row + rowOffsetFromChosenCell, col + colOffsetFromChosenCell);
                board.ColorsBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] = CellColor.RED;
            }
        }

        private static void ChooseRedColorForCell(Border cell, int paintingRow, int paintingCol)
        {
            if (paintingRow % 2 == 0)
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetRedLightRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetRedDarkRGB();
                }
            }
            else
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetRedDarkRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetRedLightRGB();
                }
            }
        }

        private static void ChooseGreenColorForCell(Border cell , int paintingRow , int paintingCol)
        {

            if (paintingRow % 2 == 0)
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetGreenLightRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetGreenDark();
                }
            }
            else
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetGreenDark();
                }
                else
                {
                    cell.Background = ChessColors.GetGreenLightRGB();
                }
            }
        }
        private static void PaintLeftRockAttackLine(MouseButtonEventArgs e, Grid gameField, int col , FiguresBoard board)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (col - 1 != -1)
                {
                    PaintCell(e, gameField, board, 0, i);
                    if (IsCellRed(e, gameField, board, 0, i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col--;
            }
        }

        private static bool IsCellRed(MouseButtonEventArgs e, Grid gameField, FiguresBoard board, int rowOffsetFromChosenCell = 0, int colOffsetFromChosenCell = 0 )
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
                .Cast<UIElement>()
                .First(e => Grid.GetRow(e) + rowOffsetFromChosenCell == row && Grid.GetColumn(e) + colOffsetFromChosenCell == col) as Border;

            if (board.ColorsBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] == CellColor.RED)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static void PaintUpRockAttackLine(MouseButtonEventArgs e, Grid gameField, int row, FiguresBoard board)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row - 1 != -1)
                {
                    PaintCell(e, gameField, board, i, 0);
                    if (IsCellRed(e, gameField, board, i, 0))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                row--;
            }
        }

        private static void PaintRightRockAttackLine(MouseButtonEventArgs e, Grid gameField, int col, FiguresBoard board)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (col + 1 != 8)
                {
                    PaintCell(e, gameField, board, 0, -i);
                    if (IsCellRed(e, gameField, board, 0, -i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col++;
            }
        }

        private static void PaintDownRockAttackLine(MouseButtonEventArgs e, Grid gameField, int row, FiguresBoard board)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row + 1 != 8)
                {
                    PaintCell(e, gameField, board, -i, 0);
                    if (IsCellRed(e, gameField, board, -i, 0))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                row++;
            }
        }

        private static void PaintLeftUpBishopAttackLine(MouseButtonEventArgs e, Grid gameField , int col , int row, FiguresBoard board)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row - 1 != -1 && col - 1 != -1)
                {
                    PaintCell(e, gameField, board, i, i);
                    if (IsCellRed(e, gameField, board, i, i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col--;
                row--;
            }
        }

        private static void PaintRightDownBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row, FiguresBoard board)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row + 1 != 8 && col + 1 != 8)
                {
                    PaintCell(e, gameField, board, -i, -i);
                    if (IsCellRed(e, gameField, board, -i, -i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col++;
                row++;
            }
        }

        private static void PaintLeftDownBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row, FiguresBoard board)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row + 1 != 8 && col - 1 != -1)
                {
                    PaintCell(e, gameField, board, -i, i);
                    if (IsCellRed(e, gameField, board, -i, i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col--;
                row++;
            }
        }

        private static void PaintRightUpBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row, FiguresBoard board)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row - 1 != -1 && col + 1 != 8)
                {
                    PaintCell(e, gameField, board, i, -i);
                    if (IsCellRed(e, gameField, board, i, -i))
                    {
                        break;
                    }
                }
                else
                {
                    fieldEnd = true;
                }
                i++;
                col++;
                row--;
            }
        }
    }
}
