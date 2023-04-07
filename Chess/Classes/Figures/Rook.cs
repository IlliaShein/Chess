﻿using Chess.Classes.Game;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    public class Rook : PluralChessPiece
    {
        public Rook(FigureColor color, int number)
            : base(color, number)
        {

        }
        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (board.colorBoard[row, col] == CellColor.RED)
            {
                Turn.changeColor();
                board.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == color)
            {
                board.PaintBoardStandartColors(e, gameField);
                board.PaintCellInYellow(gameField, e);
                FiguresLogicProcessing.RockLogicProcessing(e, gameField, board);
            }
        }
    }
}
