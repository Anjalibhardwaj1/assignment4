using System;
using System.Collections.Generic;
using System.Text;

namespace Random
{
    public interface Shape
    {
        // default implementation of interface property
        string Name => this.GetType().Name;

        double GetPerimeter();

        double GetArea();
    }

    // Rectangle implements Shape
    class Rectangle : Shape
    {
        // two sides defined using properties
        public double Length { get; set; }
        public double Width { get; set; }

        // no arg constructor
        public Rectangle() { }

        // parameterized constructor
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString() => this.GetType().Name + ", " + Length + ", " + Width;

        public double GetPerimeter() => (2 * Length) + (2 * Width);

        public double GetArea() => Length * Width;
    }

    // Circle implements Shape
    class Circle : Shape
    {
        // Radius implemented as property
        public double Radius { get; set; }

        // no arg constructor
        public Circle() { }

        // parameterized constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override string ToString() => this.GetType().Name + ", " + Radius;

        public double GetPerimeter() => 2 * Math.PI * Radius;

        public double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}