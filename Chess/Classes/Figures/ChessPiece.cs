using System.Windows.Controls;
using System.Windows.Input;

namespace Chess.Classes.Figures
{
    abstract public class ChessPiece
    {
        public FigureColor Сolor;
        protected bool IsChoosen;

        protected ChessPiece(FigureColor color)
        {
            Сolor = color;

            IsChoosen = false;
        }

        public abstract void Select(Grid gameField, MouseButtonEventArgs e);
    }


}
