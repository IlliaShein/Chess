using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    abstract public class ChessPiece
    {
        public FigureColor color;
        protected bool isChoosen;

        protected ChessPiece(FigureColor color)
        {
            this.color = color;

            isChoosen = false;
        }

        public abstract void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board);
        protected abstract void MakeTurn();
    }


}
