using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer"; 
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2020;

        job1.Display();
        job2.Display();
    }
}