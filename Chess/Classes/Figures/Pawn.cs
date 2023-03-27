using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Pawn : PluralChessPiece
    {
        bool firstTurn;

        public Pawn(FigureColor color , int number)
            : base(color , number)
        {
            firstTurn = true;
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
