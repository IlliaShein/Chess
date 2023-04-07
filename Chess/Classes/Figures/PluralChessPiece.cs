namespace Chess.Classes.Figures
{
    abstract public class PluralChessPiece : ChessPiece
    {
        public int number;

        protected PluralChessPiece(FigureColor color, int number )
            : base(color)
        {
            this.number = number;
        }
    }
}
