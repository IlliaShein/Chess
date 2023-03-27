using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    abstract class PluralChessPiece : ChessPiece
    {
        protected int number;

        protected PluralChessPiece(FigureColor color, FigureLocation location, int number)
            : base(color, location)
        {
            this.number = number;
        }
    }
}
