using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Chess.Classes.Figures;
using Chess.Classes.ChessBoard;

namespace Chess.Classes
{
    public static class FiguresLogicProcessing
    {
        public static void WhitePawnLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintCell(e, gameField, 1, 0);
            if (((Pawn)ChessBoard.ChessBoard.board[row, col]).firstTurn == true)
            {
                PaintCell(e, gameField, 2, 0);
            }
        }

        public static void BlackPawnLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintCell(e, gameField, -1, 0);
            if (((Pawn)ChessBoard.ChessBoard.board[row, col]).firstTurn == true)
            {
                PaintCell(e, gameField, -2, 0);
            }
        }

        public static void KnightLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (row > 1)
            {
                if (col != 0)
                {
                    PaintCell(e, gameField, 2, 1);
                }
                if (col != 7)
                {
                    PaintCell(e, gameField, 2, -1);
                }
            }
            if (col < 6)
            {
                if (row != 0)
                {
                    PaintCell(e, gameField, 1, -2);
                }
                if (row != 7)
                {
                    PaintCell(e, gameField, -1, -2);
                }
            }
            if (row < 6)
            {
                if (col != 0)
                {
                    PaintCell(e, gameField, -2, 1);
                }
                if (col != 7)
                {
                    PaintCell(e, gameField, -2, -1);
                }
            }
            if (col > 1)
            {
                if (row != 0)
                {
                    PaintCell(e, gameField, 1, 2);
                }
                if (row != 7)
                {
                    PaintCell(e, gameField, -1, 2);
                }
            }
        }

        public static void RockLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftRockAttackLine(e, gameField, col);
            PaintUpRockAttackLine(e, gameField, row);
            PaintRightRockAttackLine(e, gameField, col);
            PaintDownRockAttackLine(e, gameField, row);
        }

        public static void BishopLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftUpBishopAttackLine(e, gameField, col, row);
            PaintRightDownBishopAttackLine(e, gameField, col, row);
            PaintLeftDownBishopAttackLine(e, gameField, col, row);
            PaintRightUpBishopAttackLine(e, gameField, col, row);
        }

        public static void QueenLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            PaintLeftRockAttackLine(e, gameField, col);
            PaintUpRockAttackLine(e, gameField, row);
            PaintRightRockAttackLine(e, gameField, col);
            PaintDownRockAttackLine(e, gameField, row);

            PaintLeftUpBishopAttackLine(e, gameField, col, row);
            PaintRightDownBishopAttackLine(e, gameField, col, row);
            PaintLeftDownBishopAttackLine(e, gameField, col, row);
            PaintRightUpBishopAttackLine(e, gameField, col, row);
        }

        public static void KingLogicProcessing(MouseButtonEventArgs e, Grid gameField)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (col - 1 != -1 && row - 1 != -1)
            {
                PaintCell(e, gameField, 1, 1);
            }
            if (row - 1 != -1)
            {
                PaintCell(e, gameField, 1, 0);
            }
            if (row - 1 != -1 && col + 1 != 8)
            {
                PaintCell(e, gameField, 1, -1);
            }
            if (col + 1 != 8)
            {
                PaintCell(e, gameField, 0, -1);
            }
            if (row + 1 != 8)
            {
                PaintCell(e, gameField, -1, 0);
            }
            if (row + 1 != 8 && col + 1 != 8)
            {
                PaintCell(e, gameField, -1, -1);
            }
            if (row + 1 != 8 && col - 1 != -1)
            {
                PaintCell(e, gameField, -1, 1);
            }
            if (col - 1 != -1)
            {
                PaintCell(e, gameField, 0, 1);
            }
        }

        private static void PaintLeftRockAttackLine(MouseButtonEventArgs e, Grid gameField, int col)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (col - 1 != -1)
                {
                    PaintCell(e, gameField, 0, i);
                    if (IsCellRed(e, gameField, 0, i) || IsCellBrown(e, gameField, 0, i))
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

        private static void PaintUpRockAttackLine(MouseButtonEventArgs e, Grid gameField, int row)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row - 1 != -1)
                {
                    PaintCell(e, gameField, i, 0);
                    if (IsCellRed(e, gameField, i, 0) || IsCellBrown(e, gameField, i, 0))
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

        private static void PaintRightRockAttackLine(MouseButtonEventArgs e, Grid gameField, int col)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (col + 1 != 8)
                {
                    PaintCell(e, gameField, 0, -i);
                    if (IsCellRed(e, gameField, 0, -i) || IsCellBrown(e, gameField, 0, -i))
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

        private static void PaintDownRockAttackLine(MouseButtonEventArgs e, Grid gameField, int row)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row + 1 != 8)
                {
                    PaintCell(e, gameField, -i, 0);
                    if (IsCellRed(e, gameField, -i, 0) || IsCellBrown(e, gameField, -i, 0))
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

        private static void PaintLeftUpBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row)
        {
            bool fieldEnd = false;
            int i = 1;
            while (!fieldEnd)
            {
                if (row - 1 != -1 && col - 1 != -1)
                {
                    PaintCell(e, gameField, i, i);
                    if (IsCellRed(e, gameField, i, i) || IsCellBrown(e, gameField, i, i))
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

        private static void PaintRightDownBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row + 1 != 8 && col + 1 != 8)
                {
                    PaintCell(e, gameField, -i, -i);
                    if (IsCellRed(e, gameField, -i, -i) || IsCellBrown(e, gameField, -i, -i))
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

        private static void PaintLeftDownBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row + 1 != 8 && col - 1 != -1)
                {
                    PaintCell(e, gameField, -i, i);
                    if (IsCellRed(e, gameField, -i, i) || IsCellBrown(e, gameField, -i, i))
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

        private static void PaintRightUpBishopAttackLine(MouseButtonEventArgs e, Grid gameField, int col, int row)
        {
            int i = 1;
            bool fieldEnd = false;
            while (!fieldEnd)
            {
                if (row - 1 != -1 && col + 1 != 8)
                {
                    PaintCell(e, gameField, i, -i);
                    if (IsCellRed(e, gameField, i, -i) || IsCellBrown(e, gameField, i, -i))
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

        private static void PaintCell(MouseButtonEventArgs e, Grid gameField, int rowOffsetFromChosenCell = 0, int colOffsetFromChosenCell = 0)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
                .Cast<UIElement>()
                .First(e => Grid.GetRow(e) + rowOffsetFromChosenCell == row && Grid.GetColumn(e) + colOffsetFromChosenCell == col) as Border;


            if (ChessBoard.ChessBoard.board[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] == null)
            {
                ChooseGreenColorForCell(cell, row + rowOffsetFromChosenCell, col + colOffsetFromChosenCell);
                ChessBoard.ChessBoard.colorBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] = CellColor.GREEN;
            }
            else if (ChessBoard.ChessBoard.board[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)].color != ChessBoard.ChessBoard.board[row, col].color)
            {
                ChooseRedColorForCell(cell, row + rowOffsetFromChosenCell, col + colOffsetFromChosenCell);
                ChessBoard.ChessBoard.colorBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] = CellColor.RED;
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

        private static void ChooseGreenColorForCell(Border cell, int paintingRow, int paintingCol)
        {

            if (paintingRow % 2 == 0)
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetGreenLightRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetGreenDarkRGB();
                }
            }
            else
            {
                if (paintingCol % 2 == 0)
                {
                    cell.Background = ChessColors.GetGreenDarkRGB();
                }
                else
                {
                    cell.Background = ChessColors.GetGreenLightRGB();
                }
            }
        }

        private static bool IsCellRed(MouseButtonEventArgs e, Grid gameField, int rowOffsetFromChosenCell = 0, int colOffsetFromChosenCell = 0)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
                .Cast<UIElement>()
                .First(e => Grid.GetRow(e) + rowOffsetFromChosenCell == row && Grid.GetColumn(e) + colOffsetFromChosenCell == col) as Border;

            if (ChessBoard.ChessBoard.colorBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] == CellColor.RED)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsCellBrown(MouseButtonEventArgs e, Grid gameField, int rowOffsetFromChosenCell = 0, int colOffsetFromChosenCell = 0)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            Border cell = gameField.Children
                .Cast<UIElement>()
                .First(e => Grid.GetRow(e) + rowOffsetFromChosenCell == row && Grid.GetColumn(e) + colOffsetFromChosenCell == col) as Border;

            if (ChessBoard.ChessBoard.colorBoard[row + rowOffsetFromChosenCell * (-1), col + colOffsetFromChosenCell * (-1)] == CellColor.EMPTY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
