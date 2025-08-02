public class ReflectingActivity : Activity
{
    private List<string> _prompts;

    private List<string> _questions;
    public ReflectingActivity(string activityName, string description, string duration)
        : base(activityName, description, duration)
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times when you have shown strength and resilience.";
        _prompts = new List<string>
        {
            "Think of a time when you overcame a challenge.",
            "Recall a moment of personal growth.",
            "Remember a time you helped someone in need."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How did you feel at the end of it?",
            "What strengths did you use?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder each of the following questions:");
        ShowSpinner(2);

        DateTime end = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < end)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public string DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"Reflect on the following prompt: {prompt}");
        return prompt;
    }

    public string DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"Consider this question: {question}");
        return question;
    }
}