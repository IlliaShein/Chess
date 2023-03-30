using Chess.Classes.Figures;
using System;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Chess.Classes
{
    public static class GameNote
    {
        public static void AddTurn(Grid grid, ChessPiece[,] board,int toRow, int toCol, int fromRow, int fromCol)
        {
            TextBlock gameNote = (TextBlock)grid.FindName("GameNote");
            string turn = "";

            if (board[fromRow, fromCol] is Pawn)
            {
                switch (fromCol)
                {
                    case 0:
                        turn += "a";
                        break;
                    case 1:
                        turn += "b";
                        break;
                    case 2:
                        turn += "c";
                        break;
                    case 3:
                        turn += "d";
                        break;
                    case 4:
                        turn += "e";
                        break;
                    case 5:
                        turn += "f";
                        break;
                    case 6:
                        turn += "g";
                        break;
                    case 7:
                        turn += "h";
                        break;
                }
                turn += Convert.ToString(8 - (fromRow)) + " ";

                switch (toCol)
                {
                    case 0:
                        turn += "a";
                        break;
                    case 1:
                        turn += "b";
                        break;
                    case 2:
                        turn += "c";
                        break;
                    case 3:
                        turn += "d";
                        break;
                    case 4:
                        turn += "e";
                        break;
                    case 5:
                        turn += "f";
                        break;
                    case 6:
                        turn += "g";
                        break;
                    case 7:
                        turn += "h";
                        break;
                }
                turn += Convert.ToString(8 - (toRow)) + " ; ";
            }
            else if (board[fromRow, fromCol] is Rook)
            {
                turn = getMoveOfFigure(toCol, toRow, "R");
            }
            else if (board[fromRow, fromCol] is Knight)
            {
                turn = getMoveOfFigure(toCol, toRow, "N");
            }
            else if (board[fromRow, fromCol] is Bishop)
            {
                turn = getMoveOfFigure(toCol, toRow, "B");
            }
            else if (board[fromRow, fromCol] is King)
            {
                turn = getMoveOfFigure(toCol, toRow, "K");
            }
            else if (board[fromRow, fromCol] is Queen)
            {
                turn = getMoveOfFigure(toCol, toRow, "Q");
            }

            if (board[fromRow, fromCol].color == FigureColor.WHITE)
            {
                var newSpan = new Span(new Run(turn) { Foreground = ChessColors.GetWhiteRGB() });
                gameNote.Inlines.Add(newSpan);
            }
            else //board[fromRow, fromCol].color == FigureColor.BLACK
            {
                var newSpan = new Span(new Run(turn) { Foreground = ChessColors.GetBlackRGB() });
                gameNote.Inlines.Add(newSpan);
            }
        }

        private static string getMoveOfFigure(int toCol , int toRow , string figure)
        {
            string turn = figure;

            switch (toCol)
            {
                case 0:
                    turn += "a";
                    break;
                case 1:
                    turn += "b";
                    break;
                case 2:
                    turn += "c";
                    break;
                case 3:
                    turn += "d";
                    break;
                case 4:
                    turn += "e";
                    break;
                case 5:
                    turn += "f";
                    break;
                case 6:
                    turn += "g";
                    break;
                case 7:
                    turn += "h";
                    break;
            }
            turn += Convert.ToString(8 - (toRow)) + " ; ";

            return turn;
        }
    }
}
