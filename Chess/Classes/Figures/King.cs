using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    class King : ChessPiece
    {
        bool firstTurn;
        bool wasUnderMate;

        public King(FigureColor color)
            : base(color)
        {
            firstTurn = true;
            wasUnderMate = false;
        }

        public override void Select(Grid gameField, MouseButtonEventArgs e, ChessBoard.ChessBoard board)
        {
            GameLogic.PaintCellInYellow(gameField, e, board);
            GameLogic.KingLogicProcessing(e, gameField, board);
        }
        protected override void MakeTurn()
        {
            throw new NotImplementedException();
        }
    }
}
