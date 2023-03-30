using System.Windows.Media;

namespace Chess
{
    public static class ChessColors
    {
        public static SolidColorBrush GetYellowRGB()
        {
            return new SolidColorBrush(Color.FromRgb(255, 253, 148));
        }
        public static SolidColorBrush GetGreenLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(164, 255, 176));
        }
        public static SolidColorBrush GetGreenDark()
        {
            return new SolidColorBrush(Color.FromRgb(42, 146, 70));
        }
        public static SolidColorBrush GetRedLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(255, 137, 107));
        }
        public static SolidColorBrush GetRedDarkRGB()
        {
            return new SolidColorBrush(Color.FromRgb(235, 52, 35));
        }
        public static SolidColorBrush GetStandartLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(255, 253, 208));
        }
        public static SolidColorBrush GetStandartDarkRGB()
        {
            return new SolidColorBrush(Color.FromRgb(101, 67, 33));
        }
        public static SolidColorBrush GetWhiteRGB()
        {
            return new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
        public static SolidColorBrush GetBlackRGB()
        {
            return new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
    }
}
