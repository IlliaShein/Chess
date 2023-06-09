﻿using Chess.Classes;
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
            foreach (ChessPiece figure in ChessBoard.Board)
            {
                if (figure is T && ((T)figure).Сolor == color && ((T)figure).Number == number)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e);
                }
            }
        }

        public static void SelectPiece<T>(FigureColor color, MouseButtonEventArgs e, Grid GameField) where T : ChessPiece
        {
            foreach (ChessPiece figure in ChessBoard.Board)
            {
                if (figure is T && ((T)figure).Сolor == color)
                {
                    T Figure = (T)figure;
                    Figure.Select(GameField, e);
                }
            }
        }

        public static void ScreenSizeButtonLogicProcession(Window window, Grid grid)
        {
            Button FullScreen = (Button)grid.FindName("ScreenSizeButton");

            if (window.WindowState == WindowState.Normal)
            {
                window.WindowState = WindowState.Maximized;
                FullScreen.Content = "Window";
            }
            else
            {
                window.WindowState = WindowState.Normal;
                FullScreen.Content = "Full screen";
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

            if (ChessBoard.ColorBoard[row, col] == CellColor.GREEN)
            {
                for (int i = 0; i < ChessBoard.ColorBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < ChessBoard.ColorBoard.GetLength(1); j++)
                    {
                        if (ChessBoard.ColorBoard[i, j] == CellColor.YELLOW)
                        {
                            Turn.changeColor();

                            ChessBoard.MoveFigure(e, GameField, row, col, i, j);
                            GameNote.AddTurn(GameField, i, j, row, col);

                            if (ChessBoard.IfBoardTurning())
                            {
                                ChessBoard.SwitchSides(e, GameField );
                            }
                        }
                    }
                }
            }
            else if (ChessBoard.ColorBoard[row, col] != CellColor.YELLOW)
            {
                ChessBoard.PaintBoardStandartColors(e,GameField);
            }
        }
    }
}
