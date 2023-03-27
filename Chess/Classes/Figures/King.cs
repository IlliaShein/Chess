using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class King : ChessPiece
    {
        bool firstTurn;
        bool wasUnderMate;

        public King(FigureColor color, FigureLocation location)
            : base(color , location)
        {
            firstTurn = true;
            wasUnderMate = false;
        }

        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
