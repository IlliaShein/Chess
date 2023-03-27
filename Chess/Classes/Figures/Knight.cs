using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Knight : PluralChessPiece
    {
        public Knight(FigureColor color, FigureLocation location, int number)
            : base(color, location, number)
        {

        }
        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
