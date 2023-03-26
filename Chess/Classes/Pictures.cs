using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Chess.Classes
{
    public static class Pictures
    {
        public static Image GetBlackPawnImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackPawn.png"));

            return image;
        }
        public static Image GetWhitePawnImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhitePawn.png"));

            return image;
        }
        public static Image GetBlackRockImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackRook.png"));

            return image;
        }
        public static Image GetWhiteRock()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhiteRook.png"));

            return image;
        }
        public static Image GetBlackKnightImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackKnight.png"));

            return image;
        }
        public static Image GetWhiteKnightImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhiteKnight.png"));

            return image;
        }
        public static Image GetBlackBishopImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackBishop.png"));

            return image;
        }
        public static Image GetWhiteBishopImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhiteBishop.png"));

            return image;
        }
        public static Image GetWhiteKingImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhiteKing.png"));

            return image;
        }
        public static Image GetBlackKingImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackKing.png"));

            return image;
        }
        public static Image GetWhiteQueenImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\WhiteQueen.png"));

            return image;
        }

        public static Image GetBlackQueenImage()
        {
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\Illy\\Desktop\\НУЛП\\BlackQueen.png"));

            return image;
        }
    }
}
