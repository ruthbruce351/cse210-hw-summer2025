public class BreathingActivity : Activity
{
    public BreathingActivity() :
    base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.") {}
 

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