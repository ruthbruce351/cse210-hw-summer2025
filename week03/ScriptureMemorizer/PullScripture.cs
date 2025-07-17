using System;
using System.Collections.Generic;
using System.IO;

public class PullScripture
{
    public static List<Scripture> LoadFromFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"Error: File '{filename}' not found.");
            return scriptures;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length != 2) continue;

            string referenceText = parts[0].Trim();
            string verseText = parts[1].Trim();

            int lastSpaceBeforeColon = referenceText.LastIndexOf(':');
            if (lastSpaceBeforeColon == -1) continue;

            string bookAndChapter = referenceText.Substring(0, lastSpaceBeforeColon);
            string[] bookParts = bookAndChapter.Split(' ');
            string book = string.Join(" ", bookParts, 0, bookParts.Length - 1);
            int chapter = int.Parse(bookParts[^1]);

            string versePart = referenceText.Substring(lastSpaceBeforeColon + 1);
            string[] verseRange = versePart.Split('-');
            int startVerse = int.Parse(verseRange[0]);
            int endVerse = (verseRange.Length > 1) ? int.Parse(verseRange[1]) : startVerse;

            Reference reference = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(reference, verseText);
            scriptures.Add(scripture);
        }

        return scriptures;
    }
}
