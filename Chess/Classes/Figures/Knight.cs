using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Knight : PluralChessPiece
    {
        public Knight(FigureColor color, int number)
            : base(color, number)
        {

        }
        public override void Select()
        {
            throw new NotImplementedException();
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
