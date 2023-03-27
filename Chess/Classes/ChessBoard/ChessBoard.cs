using Chess.Classes.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Classes.ChessBoard
{
    class ChessBoard
    {
        public ChessPiece[,] board;

        public ChessBoard()
        {
            board = new ChessPiece[8, 8];

            FillBoard();
        }

        private void FillBoard()
        {
            board[0,0] = new Rook(FigureColor.BLACK,0);
            board[0, 6] = new Rook(FigureColor.BLACK, 1);

            board[0, 1] = new Knight(FigureColor.BLACK, 0);
            board[0, 5] = new Knight(FigureColor.BLACK, 1);

            board[0, 2] = new Bishop(FigureColor.BLACK, 0);
            board[0, 4] = new Bishop(FigureColor.BLACK, 1);

            board[0, 3] = new King(FigureColor.BLACK);
            board[0, 3] = new Queen(FigureColor.BLACK);

            for (int i = 0; i < 8; i++)
            {
                board[1, i] = new Pawn(FigureColor.BLACK,i);
                board[6, i] = new Pawn(FigureColor.WHITE, i);
            }

            board[7, 0] = new Rook(FigureColor.WHITE, 0);
            board[7, 6] = new Rook(FigureColor.WHITE, 1);

            board[7, 1] = new Knight(FigureColor.WHITE, 0);
            board[7, 5] = new Knight(FigureColor.WHITE, 1);

            board[7, 2] = new Bishop(FigureColor.WHITE, 0);
            board[7, 4] = new Bishop(FigureColor.WHITE, 1);

            board[7, 3] = new King(FigureColor.WHITE);
            board[7, 3] = new Queen(FigureColor.WHITE);
        }
    }
}
