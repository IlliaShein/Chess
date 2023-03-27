using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Queen : ChessPiece
    {

        public Queen(FigureColor color)
            : base(color )
        {

        }

        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
