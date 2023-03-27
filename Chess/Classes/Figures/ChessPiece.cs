using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    abstract class ChessPiece
    {
        public FigureColor color;
        protected bool isChoosen;

        protected ChessPiece(FigureColor color)
        {
            this.color = color;

            isChoosen = false;
        }

        public abstract void Select();
        protected abstract void MakeTurn();
    }


}
