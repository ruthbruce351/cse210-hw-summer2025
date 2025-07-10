public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Write about a challenge that you have had to overcome.",
        "Describe a memorable event from your childhood.",
        "What are your favorite hobbies?",
        "What are your goals for the next year?",
        "What is your earliest memory?",
        "Write about a place you’d like to visit.",
        "What is your favorite season and why?",
        "Describe a book or movie that inspired you.",
        "What is your favorite family tradition?",
        "What is something you’ve always wanted to learn?",
        "Reflect on a recent challenge and how you overcame it.",
        "What was your favorite subject in school and why?",
        "What does your ideal day look like?",
        "What is your favorite holiday and why?",
        "Write about a person who has influenced your life."
    };
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}