using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "red");
        Console.WriteLine($"Color of square: {square1.GetColor()}");
        Console.WriteLine($"Area of square: {square1.GetArea()}");
    }
}