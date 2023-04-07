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
        public override void Select(Grid gameField, MouseButtonEventArgs e)
        {
            int row = Grid.GetRow((UIElement)e.Source);
            int col = Grid.GetColumn((UIElement)e.Source);

            if (ChessBoard.ChessBoard.colorBoard[row, col] == CellColor.RED)
            {
                Turn.changeColor();
                ChessBoard.ChessBoard.AttackFigure(e, gameField, row, col);
            }
            else if (Turn.GetTurnColor() == color)
            {
                ChessBoard.ChessBoard.PaintBoardStandartColors(e, gameField);
                ChessBoard.ChessBoard.PaintCellInYellow(gameField, e);
                FiguresLogicProcessing.RockLogicProcessing(e, gameField);
            }
        }
    }
}
