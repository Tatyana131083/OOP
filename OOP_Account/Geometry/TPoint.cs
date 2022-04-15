using System;
using System.Drawing;

namespace Geometry
{
    internal class TPoint : Figure
    {

        public int X { get; set; }
        public int Y { get; set; }

        public TPoint() 
        {
            X = 0;
            Y = 0;
        }

        public TPoint(int x, int y, Color color, bool isVisible) : base (color, isVisible)
        {
            X = x;
            Y = y;
        }

        public void Move(int hx, int hy)
        {
            X = X + hx;
            Y = Y + hy;
        }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("X = " + X + ", Y = " + Y);
        }
    }
}
