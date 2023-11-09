using System;
using System.Collections.Generic;

namespace Learning05
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();

            // Add some shapes to the list
            shapes.Add(new Square("Red", 5.0f));
            shapes.Add(new Rectangle("Blue", 4.0f, 6.0f));
            shapes.Add(new Circle("Green", 3.0f));

            // Iterate through the list and display their colors and areas
            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"Color: {shape.Color}, Area: {shape.GetArea()}");
            }
        }
    }
}
