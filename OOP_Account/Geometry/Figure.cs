using System;
using System.Drawing;


namespace Geometry
{
    internal abstract class Figure
    {

        public Color Color { get; set; }
        public bool IsVisible { get; set; }

        public Figure()
        {
            Color = Color.Black;
            IsVisible = true;
        }
        public Figure( Color color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine("IsVisible = " + IsVisible + ", Color =  " + Color.Name);
        }
    }
}
