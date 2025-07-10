//Creativity Element: I decided to add two additional elements to the Journal Entry.
//I added a gratitude list and also a mood rating.

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        
        string choice = "";
        string answer = "";

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine();

        do
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                Entry anEntry = new Entry();
                PromptGenerator prompt = new PromptGenerator();


                anEntry._promptText = prompt.GetRandomPrompt();
                anEntry._date = DateTime.Now.ToShortDateString();

                Console.WriteLine($"{anEntry._promptText}");
                Console.Write("> ");
                anEntry._entryText = Console.ReadLine();
                Console.WriteLine();

                do
                {
                    Console.WriteLine("Would you like to add a gratitude item? (y/n) ");
                    Console.Write("> ");
                    answer = Console.ReadLine();
                    if (answer == "y")
                    {
                        Console.WriteLine("What are you grateful for? ");
                        Console.Write("> ");
                        anEntry._gratitudeItems.Add(Console.ReadLine());
                    }
                } while (answer == "y");

                Console.WriteLine();
                Console.WriteLine("How would you rate your mood on a scale of 1-10?");
                Console.Write("> ");
                anEntry._mood = Console.ReadLine();
                Console.WriteLine();

                theJournal.AddNewEntry(anEntry);

            }
            else if (choice == "2")
            {
                foreach (Entry entry in theJournal._entries)
                {
                    entry.Display();
                }
            }
            else if (choice == "3")
            {
                Console.Write("What file would you like to load from? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("What file would you like to save to? ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Sorry that choice is not recognized. Please try again!");
            }

        } while (choice != "5");
    }
}