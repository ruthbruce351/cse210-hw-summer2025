using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Test1 Test1", "Class 1");
        Assignment assignment2 = new Assignment("Test2 Test2", "Class 2");

        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment2.GetSummary());

    }
}