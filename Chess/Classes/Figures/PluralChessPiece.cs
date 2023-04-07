using Chess.Classes.Game;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    abstract public class PluralChessPiece : ChessPiece
    {
        public int number;

        protected PluralChessPiece(FigureColor color, int number )
            : base(color)
        {
            this.number = number;
        }
    }
}
