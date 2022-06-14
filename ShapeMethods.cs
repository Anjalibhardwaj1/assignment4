using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4
{
    public static class ShapeMethods
    {
        public static void Print(this Shape shape1)
        {
            Console.WriteLine(shape1.ToString());
        }

        public static Rectangle Parse(string rectangle1)
        {
            string[] input = rectangle1.Split(",");
            Rectangle rectangle2 = new Rectangle(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));
            return rectangle2;
        }
    }

    partial class Circle
    {
        public static Circle Parse(string circal1)
        {
            string[] input = circal1.Split(",");
            Circle circal2 = new Circle(Convert.ToDouble(input[1]));
            return circal2;
        }
    }
}