using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public void RemoveRandomWordAndLeaveFirstLetter()
    {
        Random random = new Random();
        var visibleWords = Words.Where(word => !word.IsHidden).ToList();

        if (visibleWords.Count > 0)
        {
            int randomIndex = random.Next(visibleWords.Count);
            Word wordToRemove = visibleWords[randomIndex];
            wordToRemove.RemoveWordAndLeaveFirstLetter();
        }
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", Words.Select(word => word.IsHidden ? word.FirstLetter + new string('_', word.RestOfWord.Length) : word.FirstLetter + word.RestOfWord));
        return $"{Reference.Verse}: {scriptureText}";
    }
}
