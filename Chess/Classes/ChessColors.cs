using System.Windows.Media;

namespace Chess
{
    public static class ChessColors
    {
        public static SolidColorBrush GetYellowLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(255, 253, 148));
        }
        public static SolidColorBrush GetYellowDarkRGB()
        {
            return new SolidColorBrush(Color.FromRgb(200, 205, 79));
        }
        public static SolidColorBrush GetGreenLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(164, 255, 176));
        }
        public static SolidColorBrush GetGreenDarkRGB()
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
        public static SolidColorBrush GetBlueLightRGB()
        {
            return new SolidColorBrush(Color.FromRgb(93, 116, 201));
        }
        public static SolidColorBrush GetBlueDarkRGB()
        {
            return new SolidColorBrush(Color.FromRgb(51, 61, 97));
        }
    }
}
