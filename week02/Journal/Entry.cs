public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public List<string> _gratitudeItems = new List<string>();
    public string _mood = "";

    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"I am grateful for: {string.Join(", ", _gratitudeItems)}");
        Console.WriteLine($"My mood is: {_mood}");
        Console.WriteLine();
    }
}