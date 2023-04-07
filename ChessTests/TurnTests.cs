using Chess;
using Chess.Classes.Game;
using Xunit;

namespace ChessTests
{ 
    public class TurnTests
    {
        [Fact]
        public void GetTurnColorTest()
        {
            FigureColor expected = FigureColor.WHITE;
            FigureColor actual = Turn.GetTurnColor();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeColorTest1()
        {

            Turn.changeColor();

            FigureColor expected = FigureColor.BLACK;
            FigureColor actual = Turn.GetTurnColor();

            Turn.changeColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeColorTest2()
        {

            Turn.changeColor();
            Turn.changeColor();

            FigureColor expected = FigureColor.WHITE;
            FigureColor actual = Turn.GetTurnColor();

            Turn.changeColor();
            Turn.changeColor();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeColorTest3()
        {

            Turn.changeColor();
            Turn.changeColor();
            Turn.changeColor();

            FigureColor expected = FigureColor.BLACK;
            FigureColor actual = Turn.GetTurnColor();

            Turn.changeColor();
            Turn.changeColor();
            Turn.changeColor();
            Assert.Equal(expected, actual);
        }
    }
}
