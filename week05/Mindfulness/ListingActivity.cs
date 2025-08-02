public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, string duration)
        : base(activityName, description, duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect by listing positive things in your life.";
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "What are you grateful for today?"
        };
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> responses = GetListFromUser();

        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                list.Add(input);
            }
        }

        return list;
    }
}