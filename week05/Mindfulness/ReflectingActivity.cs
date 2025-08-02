public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _unusedPrompts;
    private List<string> _unusedQuestions;

    private static Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting Activity", "This activity will help you reflect on times when you have shown strength and resilience.")
    {
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

        _unusedPrompts = new List<string>(_prompts);
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    private void DisplayQuestions()
    {
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
    }

    private string GetRandomPrompt()
    {
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        return prompt;
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);

        return question;
    }
}
