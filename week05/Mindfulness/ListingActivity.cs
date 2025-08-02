using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _unusedPrompts;
    private static Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity", "This activity will help you reflect by listing positive things in your life.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "What are you grateful for today?"
        };

        _unusedPrompts = new List<string>(_prompts);
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
        if (_unusedPrompts.Count == 0)
        {
            _unusedPrompts = new List<string>(_prompts);
        }

        int index = _random.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        return prompt;
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
