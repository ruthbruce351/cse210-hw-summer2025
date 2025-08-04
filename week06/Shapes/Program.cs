using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5, "Red"));
        shapes.Add(new Square(4, "Blue"));
        shapes.Add(new Rectangle(3, 6, "Green"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}