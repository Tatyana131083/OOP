using System;
using System.Drawing;


namespace Geometry
{
    internal class RightTriangle : TPoint
    {
        //сторона а катет
        public double A { get; set; }
        //сторона b катет
        public double B { get; set; }
        //cторона с гипотенуза
        public double C { get { return Math.Sqrt(A * A + B * B); } }

        public RightTriangle() { }

        public RightTriangle(double a, double b,  int x, int y, Color color, bool isVisible) : base(x, y, color, isVisible)
        {
            A = a;
            B = b;
        }


        public double Area()
        {
            return 0.5 * A * B;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("A = " + A + ", B=" + B + ", C=" + C);           
            Console.WriteLine($"Area = {Area()}");
            Console.WriteLine();
        }
    }
}
