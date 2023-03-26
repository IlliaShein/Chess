using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class Figure
    {
        public FigureName name { get; }
        public FigureColor color { get; }
        public bool startPosition = false;

        public Figure(FigureName name , FigureColor color)
        {
            this.name = name;
            this.color = color;
        }

        public Figure( Figure figure)
        {
            this.name = figure.name;
            this.color = figure.color;
        }
    }
}
