using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        if (visibleIndexes.Count <= count)
        {
            foreach (int i in visibleIndexes)
            {
                _words[i].Hide();
            }
            return;
        }

        Random rand = new Random();
        for (int i = 0; i < count; i++)
        {
            int randIndex = rand.Next(visibleIndexes.Count);
            int wordToHideIndex = visibleIndexes[randIndex];
            _words[wordToHideIndex].Hide();
            visibleIndexes.RemoveAt(randIndex);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
}