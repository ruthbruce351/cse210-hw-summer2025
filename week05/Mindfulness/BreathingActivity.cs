public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, string duration)
        : base(activityName, description, duration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding you through breathing in and out slowly.";
    }   

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Clear your mind and focus on your breathing...");
        ShowSpinner(2);

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountdown(3);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}