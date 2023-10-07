using System;
using System.IO;

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        // Initialize the properties of the JournalEntry.
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void DisplayEntry()
    {
        // Display the date, prompt, and response of a journal entry.
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public void SaveEntry(StreamWriter writer)
    {
        // Write the date, prompt, and response to a StreamWriter.
        writer.WriteLine($"{Date},{Prompt},{Response}");
    }
}
