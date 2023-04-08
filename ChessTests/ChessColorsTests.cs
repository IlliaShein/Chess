using System.Windows.Media;
using Chess;
using Xunit;

namespace ChessTests
{
    public class ChessColorsTests
    {
        [Fact]
        public void GetYellowRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetYellowRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(255, 253, 148));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetGreenLightRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetGreenLightRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(164, 255, 176));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetGreenDarkRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetGreenDarkRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(42, 146, 70));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetRedLightRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetRedLightRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(255, 137, 107));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetRedDarkRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetRedDarkRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(235, 52, 35));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetStandartLightRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetStandartLightRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(255, 253, 208));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetStandartDarkRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetStandartDarkRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(101, 67, 33));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetWhiteRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetWhiteRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetBlackRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetBlackRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(0, 0, 0));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetBlueLightRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetBlueLightRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(93, 116, 201));

            Assert.Equal(expected.ToString(), actual.ToString());
        }

        [Fact]
        public void GetBlueDarkRGBTest()
        {
            SolidColorBrush actual = ChessColors.GetBlueDarkRGB();
            SolidColorBrush expected = new SolidColorBrush(Color.FromRgb(51, 61, 97));

            Assert.Equal(expected.ToString(), actual.ToString());
        }
    }
}
