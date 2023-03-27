using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    abstract class ChessPiece
    {
        protected FigureColor color;
        protected FigureLocation location;
        protected bool isChoosen;

        protected ChessPiece(FigureColor color, FigureLocation location)
        {
            this.color = color;
            this.location = location;

            isChoosen = false;
        }

        public abstract void MakeTurn();
    }


}
