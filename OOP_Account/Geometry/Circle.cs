using System;
using System.Drawing;

namespace Geometry
{
    internal class Circle : TPoint
    {
        public int Radius { get; set; }


        public Circle() {}

        public Circle(int radius, int x, int y, Color color, bool isVisible) : base(x, y, color, isVisible)
        { 
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Radius = " + Radius);
            Console.WriteLine($"Area = {Area()}");
            Console.WriteLine();
        }


    }
}
