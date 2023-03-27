﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.Figures
{
    class Pawn : PluralChessPiece
    {
        bool firstTurn;

        public Pawn(FigureColor color, FigureLocation location , int number)
            : base(color , location , number)
        {
            firstTurn = true;
        }
        public override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
