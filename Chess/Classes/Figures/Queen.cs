using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Queen : ChessPiece
    {

        public Queen(FigureColor color, FigureLocation location)
            : base(color , location)
        {

        }

        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
