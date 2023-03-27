using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Bishop : PluralChessPiece
    {
        public Bishop(FigureColor color , int number)
           : base(color,  number)
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
