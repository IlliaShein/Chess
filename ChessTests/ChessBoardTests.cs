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

            int colorBoardRowsReal = ChessBoard.colorBoard.GetLength(0);
            int colorBoardColumnsReal = ChessBoard.colorBoard.GetLength(1);

            int expectedValue = 8;

            Assert.Equal(expectedValue, colorBoardRowsReal);
            Assert.Equal(expectedValue, colorBoardColumnsReal);
        }

        [Fact]
        public void FillBoardTest1_Size()
        {
            ChessBoard.FillBoard();

            int boardRowsReal = ChessBoard.board.GetLength(0);
            int boardColumnsReal = ChessBoard.board.GetLength(1);

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

            if (((Rook)ChessBoard.board[0, 0]).number != 0 || ((Rook)ChessBoard.board[7, 0]).number != 0 ||
                ((Rook)ChessBoard.board[0, 7]).number != 1 || ((Rook)ChessBoard.board[7, 7]).number != 1 ||
                ((Knight)ChessBoard.board[0, 1]).number != 0 || ((Knight)ChessBoard.board[7, 1]).number != 0 ||
                ((Knight)ChessBoard.board[0, 6]).number != 1 || ((Knight)ChessBoard.board[7, 6]).number != 1 ||
                ((Bishop)ChessBoard.board[0, 2]).number != 0 || ((Bishop)ChessBoard.board[7, 2]).number != 0 ||
                ((Bishop)ChessBoard.board[0, 5]).number != 1 || ((Bishop)ChessBoard.board[7, 5]).number != 1)
            {
                correctNumbering = false;
            }

            return correctNumbering;
        }
        private bool CheckPawnNumbering()
        {
            ChessBoard.FillBoard();

            bool correctNumbering = true;

            for (int i = 0; i < ChessBoard.board.GetLength(1); i++)
            {
                if (((Pawn)ChessBoard.board[1, i]).number != i || ((Pawn)ChessBoard.board[6, i]).number != i)
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

            for (int i = 0; i < ChessBoard.board.GetLength(1); i++)
            {
                if (ChessBoard.board[0, i].color != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (ChessBoard.board[1, i].color != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }

                for (int j = 2; j < 6; j++)
                {
                    if (ChessBoard.board[j, i] != null)
                    {
                        correctColors = false;
                        return correctColors;
                    }
                }

                if (ChessBoard.board[6, i].color != FigureColor.WHITE)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (ChessBoard.board[7, i].color != FigureColor.WHITE)
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

            for (int i = 0; i < ChessBoard.colorBoard.GetLength(0); i++)
            {
                for (int j = 0; j < ChessBoard.colorBoard.GetLength(1); j++)
                {
                    if(ChessBoard.colorBoard[i,j] != CellColor.EMPTY)
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

            for (int i = 2; i < ChessBoard.board.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < ChessBoard.board.GetLength(1); j++)
                {
                    if (ChessBoard.board[i, j] != null)
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

            for (int i = 0; i < ChessBoard.board.GetLength(0); i++)
            {
                if (!(ChessBoard.board[1, i] is Pawn))
                {
                    correctFilling = false;
                    return correctFilling;
                }
                if (!(ChessBoard.board[6, i] is Pawn))
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

            if (!(ChessBoard.board[row, 0] is Rook)
                && !(ChessBoard.board[row, 7] is Rook)
                && !(ChessBoard.board[row, 1] is Knight)
                && !(ChessBoard.board[row, 6] is Rook)
                && !(ChessBoard.board[row, 2] is Bishop)
                && !(ChessBoard.board[row, 5] is Bishop)
                && !(ChessBoard.board[row, 4] is King)
                && !(ChessBoard.board[row, 3] is Queen))
            {
                correctFilling = false;
            }

            return correctFilling;
        }
    }
}
