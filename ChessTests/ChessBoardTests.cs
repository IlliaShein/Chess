using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessBoardTests
    {
        [Fact]
        public void FillColorBoardTest1()
        {
            ChessBoard.FillColorBoard();

            int colorBoardRowsReal = ChessBoard.ColorBoard.GetLength(0);
            int colorBoardColumnsReal = ChessBoard.ColorBoard.GetLength(1);

            int expectedValue = 8;

            Assert.Equal(expectedValue, colorBoardRowsReal);
            Assert.Equal(expectedValue, colorBoardColumnsReal);
        }

        [Fact]
        public void FillBoardTest1_Size()
        {
            ChessBoard.FillBoard();

            int boardRowsReal = ChessBoard.Board.GetLength(0);
            int boardColumnsReal = ChessBoard.Board.GetLength(1);

            int expectedValue = 8;

            Assert.Equal(expectedValue, boardRowsReal);
            Assert.Equal(expectedValue, boardColumnsReal);
        }

        [Fact]
        public void FillBoardTest2_Types()
        {
            ChessBoard.FillBoard();

            bool correctFilling = true;
            if(!CheckTypes())
            {
                correctFilling = false;
            }

            Assert.True(correctFilling);
        }

        [Fact]
        public void FillBoardTest3_Colors()
        {
            ChessBoard.FillBoard();

            bool correctColors = true;
            if (!CheckColors())
            {
                correctColors = false;
            }

            Assert.True(correctColors);
        }

        [Fact]
        public void FillBoard4_Numbering()
        {
            ChessBoard.FillBoard();

            bool correctNumbering = true;
            if (!CheckNumbering())
            {
                correctNumbering = false;
            }

            Assert.True(correctNumbering);
        }

        private bool CheckNumbering()
        {
            ChessBoard.FillBoard();

            bool correctNumbering = true;

            if (!CheckFiguresNumbering())
            {
                correctNumbering = false;
                return correctNumbering;
            }
            if (!CheckPawnNumbering())
            {
                correctNumbering = false;
                return correctNumbering;
            }

            return correctNumbering;
        }

        private bool CheckFiguresNumbering()
        {
            ChessBoard.FillBoard();

            bool correctNumbering = true;

            if (((Rook)ChessBoard.Board[0, 0]).Number != 0 || ((Rook)ChessBoard.Board[7, 0]).Number != 0 ||
                ((Rook)ChessBoard.Board[0, 7]).Number != 1 || ((Rook)ChessBoard.Board[7, 7]).Number != 1 ||
                ((Knight)ChessBoard.Board[0, 1]).Number != 0 || ((Knight)ChessBoard.Board[7, 1]).Number != 0 ||
                ((Knight)ChessBoard.Board[0, 6]).Number != 1 || ((Knight)ChessBoard.Board[7, 6]).Number != 1 ||
                ((Bishop)ChessBoard.Board[0, 2]).Number != 0 || ((Bishop)ChessBoard.Board[7, 2]).Number != 0 ||
                ((Bishop)ChessBoard.Board[0, 5]).Number != 1 || ((Bishop)ChessBoard.Board[7, 5]).Number != 1)
            {
                correctNumbering = false;
            }

            return correctNumbering;
        }
        private bool CheckPawnNumbering()
        {
            ChessBoard.FillBoard();

            bool correctNumbering = true;

            for (int i = 0; i < ChessBoard.Board.GetLength(1); i++)
            {
                if (((Pawn)ChessBoard.Board[1, i]).Number != i || ((Pawn)ChessBoard.Board[6, i]).Number != i)
                {
                    correctNumbering = false;
                    return correctNumbering;
                }
            }

            return correctNumbering;
        }

        private bool CheckColors()
        {
            ChessBoard.FillBoard();

            bool correctColors = true;

            for (int i = 0; i < ChessBoard.Board.GetLength(1); i++)
            {
                if (ChessBoard.Board[0, i].Ñolor != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (ChessBoard.Board[1, i].Ñolor != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }

                for (int j = 2; j < 6; j++)
                {
                    if (ChessBoard.Board[j, i] != null)
                    {
                        correctColors = false;
                        return correctColors;
                    }
                }

                if (ChessBoard.Board[6, i].Ñolor != FigureColor.WHITE)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (ChessBoard.Board[7, i].Ñolor != FigureColor.WHITE)
                {
                    correctColors = false;
                    return correctColors;
                }
            }

            return correctColors;
        }

        private bool CheckTypes()
        {
            ChessBoard.FillBoard();

            bool correctFilling = true;

            if (!CheckTypesBoard())
            {
                correctFilling = false;
            }
            else if (!CheckTypesColorBoard())
            {
                correctFilling = false;
            }

            return correctFilling;
        }

        private bool CheckTypesColorBoard()
        {
            ChessBoard.FillColorBoard();

            bool correctFilling = true;

            for (int i = 0; i < ChessBoard.ColorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ChessBoard.ColorBoard.GetLength(1); j++)
                {
                    if(ChessBoard.ColorBoard[i,j] != CellColor.EMPTY)
                    {
                        correctFilling = false;
                        return correctFilling;
                    }
                }
            }

            return correctFilling;
        }

        private bool CheckTypesBoard()
        {
            ChessBoard.FillBoard();

            bool correctFilling = true;
            if (!CheckFiguresTypeRow(0))
            {
                correctFilling = false;
            }
            else if (!CheckFiguresTypeRow(7))
            {
                correctFilling = false;
            }
            else if (!CheckPawns())
            {
                correctFilling = false;
            }
            else if (!CheckEmptyCells())
            {
                correctFilling = false;
            }

            return correctFilling;
        }

        private bool CheckEmptyCells()
        {
            ChessBoard.FillBoard();

            bool correctFilling = true; 

            for (int i = 2; i < ChessBoard.Board.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < ChessBoard.Board.GetLength(1); j++)
                {
                    if (ChessBoard.Board[i, j] != null)
                    {
                        correctFilling = false;
                        return correctFilling;
                    }
                }
            }

            return correctFilling;
        }

        private bool CheckPawns()
        {
            ChessBoard.FillBoard();

            bool correctFilling = true;

            for (int i = 0; i < ChessBoard.Board.GetLength(0); i++)
            {
                if (!(ChessBoard.Board[1, i] is Pawn))
                {
                    correctFilling = false;
                    return correctFilling;
                }
                if (!(ChessBoard.Board[6, i] is Pawn))
                {
                    correctFilling = false;
                    return correctFilling;
                }
            }

            return correctFilling;
        }

        private bool CheckFiguresTypeRow( int row)
        {
            ChessBoard.FillBoard();

            bool correctFilling = true;

            if (!(ChessBoard.Board[row, 0] is Rook)
                && !(ChessBoard.Board[row, 7] is Rook)
                && !(ChessBoard.Board[row, 1] is Knight)
                && !(ChessBoard.Board[row, 6] is Rook)
                && !(ChessBoard.Board[row, 2] is Bishop)
                && !(ChessBoard.Board[row, 5] is Bishop)
                && !(ChessBoard.Board[row, 4] is King)
                && !(ChessBoard.Board[row, 3] is Queen))
            {
                correctFilling = false;
            }

            return correctFilling;
        }
    }
}
