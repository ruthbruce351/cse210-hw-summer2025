public class Activity
{
    private string _name;
    private string _description;
    private string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting Message {_name} {_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Ending Message {_name} {_description}");
    }

    public void ShowSpinner(int seconds)
    {

    }
    
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"{i}");
            System.Threading.Thread.Sleep(1000);
        }
    }
}