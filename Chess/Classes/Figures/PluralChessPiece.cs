namespace Chess.Classes.Figures
{
    abstract public class PluralChessPiece : ChessPiece
    {
        public int Number;

        protected PluralChessPiece(FigureColor color, int number )
            : base(color)
        {
            Number = number;
        }
    }
}
