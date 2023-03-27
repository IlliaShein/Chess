using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    abstract class PluralChessPiece : ChessPiece
    {
        public int number;

        protected PluralChessPiece(FigureColor color, int number)
            : base(color)
        {
            this.number = number;
        }
    }
}
