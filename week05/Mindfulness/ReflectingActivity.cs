public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What is something you are grateful for?",
        "What is a challenge you overcame recently?",
        "What is a goal you want to achieve?",
        "What is a lesson you learned from a past experience?"
    };

    private List<string> _questions = new List<string>
    {
        "How did that make you feel?",
        "What did you learn from that experience?",
        "How can you apply this lesson in the future?",
        "What would you do differently next time?"
    };

    public ReflectingActivity(string activityName, string description, string duration)
        : base(activityName, description, duration)
    {
    }

    public void Run()
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
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