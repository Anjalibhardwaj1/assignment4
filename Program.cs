using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment4
{
    class Program
    {
        // Create a list of shapes.
        static List<Shape> shape_list = new List<Shape>();

        static void current_(string current)
        {
            //Console.WriteLine(current);
            if (current.Split(",")[0].ToLower() == "rectangle")
            {
                shape_list.Add(ShapeMethods.Parse(current));
            }
            else
            {
                shape_list.Add(Circle.Parse(current));
            }
        }

        static void Main(string[] args)
        {
            //in class text.. the delegate is equal to the delegate witht the parameters of the method.
            //subscriber1, this code is just to instantiate
            TextFileProcessor.LineRead += new TextFileProcessor.eventDelegate(current_);
            //this will trigger the event
            TextFileProcessor.Read(@"C:\Users\r_mobeen\source\repos\Random\Random\shapes.txt");

            //sorts by shape name THEN shape area
            List<Shape> sortedByNameThenArea = shape_list.OrderBy(x => x.Name)
                                    .ThenBy(x => x.GetArea())
                                    .ToList();
            //displays the result of the sort
            Console.WriteLine("sort by name and area:");
            sortedByNameThenArea.ForEach(e => Console.WriteLine(e));
            Console.WriteLine(" ");

            //sort by perimeter only
            List<Shape> sortedByPerimeter = shape_list.OrderBy(x => x.GetPerimeter()).ToList();
            //display the result of the sort
            Console.WriteLine("sort by perimeter only: ");
            sortedByPerimeter.ForEach(e => Console.WriteLine(e));
            Console.WriteLine(" ");

            // bullet 4 and 5 left ..
        }
    }
}
