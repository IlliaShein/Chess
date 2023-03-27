using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Bishop : PluralChessPiece
    {
        public Bishop(FigureColor color, FigureLocation location, int number)
           : base(color, location, number)
        {

        }
        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
