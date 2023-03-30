using Chess.Classes.ChessBoard;
using Chess.Classes.Figures;
using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessBoardTests
    {
        [Fact]
        public void ChessBoardConstructorTest1_ArraysSize()
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
        public void ChessBoardConstructorTest2_Types()
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
        public void ChessBoardConstructorTest3_Colors()
        {
            ChessBoard chessBoard = new ChessBoard();

            bool correctColors = true;
            if (!CheckColors(chessBoard.board))
            {
                correctColors = false;
            }

            Assert.True(correctColors);
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
            if (!CheckTypesColorBoard(chessBoard.colorBoard))
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
                return correctFilling;
            }
            if (!CheckFiguresTypeRow(chessBoard, 7))
            {
                correctFilling = false;
                return correctFilling;
            }
            if (!CheckPawns(chessBoard))
            {
                correctFilling = false;
                return correctFilling;
            }
            if (!CheckEmptyCells(chessBoard))
            {
                correctFilling = false;
                return correctFilling;
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
