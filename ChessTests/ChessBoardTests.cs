using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessBoardTests
    {
        [Fact]
        public void ConstructorTest1_ArraysSize()
        {
            ChessBoard chessBoard = new ChessBoard();

            int boardRowsReal = chessBoard.board.GetLength(0);
            int boardColumnsReal = chessBoard.board.GetLength(1);
            int colorBoardRowsReal = chessBoard.colorBoard.GetLength(0);
            int colorBoardColumnsReal = chessBoard.colorBoard.GetLength(1);

            int expectedValue = 8;

            Assert.Equal(expectedValue, boardRowsReal);
            Assert.Equal(expectedValue, boardColumnsReal);
            Assert.Equal(expectedValue, colorBoardRowsReal);
            Assert.Equal(expectedValue, colorBoardColumnsReal);
        }

        [Fact]
        public void ConstructorTest2_Types()
        {
            ChessBoard chessBoard = new ChessBoard();

            bool correctFilling = true;
            if(!CheckTypes(chessBoard))
            {
                correctFilling = false;
            }

            Assert.True(correctFilling);
        }

        [Fact]
        public void ConstructorTest3_Colors()
        {
            ChessBoard chessBoard = new ChessBoard();

            bool correctColors = true;
            if (!CheckColors(chessBoard.board))
            {
                correctColors = false;
            }

            Assert.True(correctColors);
        }

        [Fact]
        public void ConstructorTest4_Numbering()
        {
            ChessBoard chessBoard = new ChessBoard();

            bool correctNumbering = true;
            if (!CheckNumbering(chessBoard.board))
            {
                correctNumbering = false;
            }

            Assert.True(correctNumbering);
        }

        private bool CheckNumbering(ChessPiece[,] board)
        {
            bool correctNumbering = true;

            if (!CheckFiguresNumbering(board))
            {
                correctNumbering = false;
                return correctNumbering;
            }
            if (!CheckPawnNumbering(board))
            {
                correctNumbering = false;
                return correctNumbering;
            }

            return correctNumbering;
        }

        private bool CheckFiguresNumbering(ChessPiece[,] board)
        {
            bool correctNumbering = true;

            if (((Rook)board[0, 0]).number != 0 || ((Rook)board[7, 0]).number != 0 ||
                ((Rook)board[0, 7]).number != 1 || ((Rook)board[7, 7]).number != 1 ||
                ((Knight)board[0, 1]).number != 0 || ((Knight)board[7, 1]).number != 0 ||
                ((Knight)board[0, 6]).number != 1 || ((Knight)board[7, 6]).number != 1 ||
                ((Bishop)board[0, 2]).number != 0 || ((Bishop)board[7, 2]).number != 0 ||
                ((Bishop)board[0, 5]).number != 1 || ((Bishop)board[7, 5]).number != 1)
            {
                correctNumbering = false;
            }

            return correctNumbering;
        }
        private bool CheckPawnNumbering(ChessPiece[,] board)
        {
            bool correctNumbering = true;

            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (((Pawn)board[1, i]).number != i || ((Pawn)board[6, i]).number != i)
                {
                    correctNumbering = false;
                    return correctNumbering;
                }
            }

            return correctNumbering;
        }

        private bool CheckColors(ChessPiece[,] chessBoard)
        {
            bool correctColors = true;

            for (int i = 0; i < chessBoard.GetLength(1); i++)
            {
                if (chessBoard[0, i].color != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (chessBoard[1, i].color != FigureColor.BLACK)
                {
                    correctColors = false;
                    return correctColors;
                }

                for (int j = 2; j < 6; j++)
                {
                    if (chessBoard[j, i] != null)
                    {
                        correctColors = false;
                        return correctColors;
                    }
                }

                if (chessBoard[6, i].color != FigureColor.WHITE)
                {
                    correctColors = false;
                    return correctColors;
                }
                if (chessBoard[7, i].color != FigureColor.WHITE)
                {
                    correctColors = false;
                    return correctColors;
                }
            }

            return correctColors;
        }

        private bool CheckTypes(ChessBoard chessBoard)
        {
            bool correctFilling = true;

            if (!CheckTypesBoard(chessBoard.board))
            {
                correctFilling = false;
            }
            else if (!CheckTypesColorBoard(chessBoard.colorBoard))
            {
                correctFilling = false;
            }

            return correctFilling;
        }

        private bool CheckTypesColorBoard(CellColor[,] chessBoard)
        {
            bool correctFilling = true;

            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    if(chessBoard[i,j] != CellColor.EMPTY)
                    {
                        correctFilling = false;
                        return correctFilling;
                    }
                }
            }

            return correctFilling;
        }

        private bool CheckTypesBoard(ChessPiece[,] chessBoard)
        {
            bool correctFilling = true;
            if (!CheckFiguresTypeRow(chessBoard, 0))
            {
                correctFilling = false;
            }
            else if (!CheckFiguresTypeRow(chessBoard, 7))
            {
                correctFilling = false;
            }
            else if (!CheckPawns(chessBoard))
            {
                correctFilling = false;
            }
            else if (!CheckEmptyCells(chessBoard))
            {
                correctFilling = false;
            }

            return correctFilling;
        }

        private bool CheckEmptyCells(ChessPiece[,] chessBoard)
        {
            bool correctFilling = true; 

            for (int i = 2; i < chessBoard.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < chessBoard.GetLength(1); j++)
                {
                    if (chessBoard[i, j] != null)
                    {
                        correctFilling = false;
                        return correctFilling;
                    }
                }
            }

            return correctFilling;
        }

        private bool CheckPawns(ChessPiece[,] chessBoard)
        {
            bool correctFilling = true;

            for (int i = 0; i < chessBoard.GetLength(0); i++)
            {
                if (!(chessBoard[1, i] is Pawn))
                {
                    correctFilling = false;
                    return correctFilling;
                }
                if (!(chessBoard[6, i] is Pawn))
                {
                    correctFilling = false;
                    return correctFilling;
                }
            }

            return correctFilling;
        }

        private bool CheckFiguresTypeRow(ChessPiece[,] chessBoard, int row)
        {
            bool correctFilling = true;

            if (!(chessBoard[row, 0] is Rook)
                && !(chessBoard[row, 7] is Rook)
                && !(chessBoard[row, 1] is Knight)
                && !(chessBoard[row, 6] is Rook)
                && !(chessBoard[row, 2] is Bishop)
                && !(chessBoard[row, 5] is Bishop)
                && !(chessBoard[row, 4] is King)
                && !(chessBoard[row, 3] is Queen))
            {
                correctFilling = false;
            }

            return correctFilling;
        }
    }
}
