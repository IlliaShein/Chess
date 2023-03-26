using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes
{
    public class Pawn : Figure
    {
        private bool firstTurn; 

        public Pawn(FigureName name, FigureColor color)
            : base(name, color)
        {
            firstTurn = true;
        }
    }
}
