public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string activityName, string description, string duration)
        : base(activityName, description, duration)
    {
        _count = 0;
        _prompts = new List<string>
        {
            "List your favorite things about today.",
            "List the people you are grateful for.",
            "List your goals for the week.",
            "List the things that make you happy.",
            "List the skills you want to improve."
        };
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[index]}");
    }

    public List<string> GetListFromUser()
    {
       return new List<string>(); 
    }
}