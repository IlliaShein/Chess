using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes
{
    public class FiguresBoard
    {
        public Figure[,] figuresBoard;
        public CellColor[,] ColorsBoard;

        public FiguresBoard()
        {
            FillFigureBoard();
            FillColorsBoard();
        }

        private void FillColorsBoard()
        {
            ColorsBoard = new CellColor[8, 8];

            for (int i = 0; i < ColorsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ColorsBoard.GetLength(1); j++)
                {
                    ColorsBoard[i, j] = CellColor.EMPTY;
                }
            }

        }

        private void FillFigureBoard()
        {
            figuresBoard = new Figure[8, 8];

            figuresBoard[0,0] = new Figure(FigureName.ROCK1, FigureColor.BLACK);
            figuresBoard[0, 7] = new Figure(FigureName.ROCK2, FigureColor.BLACK);

            figuresBoard[0, 1] = new Figure(FigureName.KNIGHT1, FigureColor.BLACK);
            figuresBoard[0, 6] = new Figure(FigureName.KNIGHT2, FigureColor.BLACK);

            figuresBoard[0, 2] = new Figure(FigureName.BISHOP1, FigureColor.BLACK);
            figuresBoard[0, 5] = new Figure(FigureName.BISHOP2, FigureColor.BLACK);

            figuresBoard[0, 4] = new Figure(FigureName.KING, FigureColor.BLACK);
            figuresBoard[0, 3] = new Figure(FigureName.QUEEN, FigureColor.BLACK);

            figuresBoard[1, 0] = new Figure(FigureName.PAWN0, FigureColor.BLACK);
            figuresBoard[1, 1] = new Figure(FigureName.PAWN1, FigureColor.BLACK);
            figuresBoard[1, 2] = new Figure(FigureName.PAWN2, FigureColor.BLACK);
            figuresBoard[1, 3] = new Figure(FigureName.PAWN3, FigureColor.BLACK);
            figuresBoard[1, 4] = new Figure(FigureName.PAWN4, FigureColor.BLACK);
            figuresBoard[1, 5] = new Figure(FigureName.PAWN5, FigureColor.BLACK);
            figuresBoard[1, 6] = new Figure(FigureName.PAWN6, FigureColor.BLACK);
            figuresBoard[1, 7] = new Figure(FigureName.PAWN7, FigureColor.BLACK);

            figuresBoard[6, 0] = new Figure(FigureName.PAWN0, FigureColor.WHITE);
            figuresBoard[6, 1] = new Figure(FigureName.PAWN1, FigureColor.WHITE);
            figuresBoard[6, 2] = new Figure(FigureName.PAWN2, FigureColor.WHITE);
            figuresBoard[6, 3] = new Figure(FigureName.PAWN3, FigureColor.WHITE);
            figuresBoard[6, 4] = new Figure(FigureName.PAWN4, FigureColor.WHITE);
            figuresBoard[6, 5] = new Figure(FigureName.PAWN5, FigureColor.WHITE);
            figuresBoard[6, 6] = new Figure(FigureName.PAWN6, FigureColor.WHITE);
            figuresBoard[6, 7] = new Figure(FigureName.PAWN7, FigureColor.WHITE);

            figuresBoard[7, 0] = new Figure(FigureName.ROCK1, FigureColor.WHITE);
            figuresBoard[7, 7] = new Figure(FigureName.ROCK2, FigureColor.WHITE);

            figuresBoard[7, 1] = new Figure(FigureName.KNIGHT1, FigureColor.WHITE);
            figuresBoard[7, 6] = new Figure(FigureName.KNIGHT2, FigureColor.WHITE);

            figuresBoard[7, 2] = new Figure(FigureName.BISHOP1, FigureColor.WHITE);
            figuresBoard[7, 5] = new Figure(FigureName.BISHOP2, FigureColor.WHITE);

            figuresBoard[7, 4] = new Figure(FigureName.KING, FigureColor.WHITE);
            figuresBoard[7, 3] = new Figure(FigureName.QUEEN, FigureColor.WHITE);

        }
    }
}
