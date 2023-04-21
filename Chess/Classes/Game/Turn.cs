namespace Chess.Classes.Game
{
    public static class Turn
    {
        private static FigureColor _turnColor = FigureColor.WHITE;


        public static FigureColor GetTurnColor()
        {
            return _turnColor;
        }

        public static void SetColor(FigureColor color)
        {
            _turnColor = color;
        }

        public static void changeColor()
        {
            if(_turnColor == FigureColor.WHITE)
            {
                _turnColor = FigureColor.BLACK;
            }
            else
            {
                _turnColor = FigureColor.WHITE;
            }
        }
    }
}
