namespace Chess.Classes.Game
{
    public static class Turn
    {
        private static FigureColor TurnColor = FigureColor.WHITE;


        public static FigureColor GetTurnColor()
        {
            return TurnColor;
        }

        public static void changeColor()
        {
            if(TurnColor == FigureColor.WHITE)
            {
                TurnColor = FigureColor.BLACK;
            }
            else
            {
                TurnColor = FigureColor.WHITE;
            }
        }
    }
}
