using System;
using System.Drawing;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Circle1");
            Circle circle1 = new Circle();
            circle1.PrintInfo();

            Console.WriteLine("Circle2");
            Circle circle2 = new Circle(25, 1, 2, Color.Red, true);
            circle2.PrintInfo();
            circle2.Move(5, 0);
            circle2.PrintInfo();

            Console.WriteLine("RightTriangle1");
            RightTriangle rightTriangle1 = new RightTriangle();
            rightTriangle1.PrintInfo();

            Console.WriteLine("RightTriangle2");
            RightTriangle rightTriangle2 = new RightTriangle(100, 150, 0, -1, Color.Red, true);
            rightTriangle2.PrintInfo();
            rightTriangle2.Move(0, 10);
            rightTriangle2.PrintInfo();

        }
    }
}
