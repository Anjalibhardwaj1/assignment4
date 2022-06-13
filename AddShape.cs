using System;
using System.Collections.Generic;
using System.Text;

namespace assignment4 {

    public static class ShapeMethods {
        public static void Print(this Shape shape1) {
            Console.WriteLine(shape1.ToString());
        }

        public static Rectangle Parse(string rectangle1) {
            string [] input = rectangle1.Split(",");
            Rectangle rectangle2 = new Rectangle(Convert.ToDouble(input[1]), Convert.ToDouble(input[2]));
            return rectangle2;
        }
    }

    partial class Circle {
        public static Circle Parse(string circal1) {
            string [] input = circal1.Split(",");
            Circle circal2 = new Circle(Convert.ToDouble(input[1]));
            return circal2;
        }
    }
    
    public class Test {
        
        public static void Main() {
            Rectangle rectangle3 = new Rectangle(2.0, 5.0);
            rectangle3.Print();
            
            rectangle3 = ShapeMethods.Parse("Rectangle,2,3.5");
            rectangle3.Print();
            
            Circle circal3 = new Circle(10.0);
            circal3.Print();
            
           circal3 = Circle.Parse("Circle, 2");
            circal3.Print();
        }
    }

}



