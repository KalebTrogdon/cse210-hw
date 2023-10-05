using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("Journal Program Menu:");
            Console.WriteLine("1: Write a new entry");
            Console.WriteLine("2: Display journal");
            Console.WriteLine("3: Save journal");
            Console.WriteLine("4: Load journal");
            Console.WriteLine("5: Exit program");
            Console.Write("Enter your choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        journal.WriteNewEntry();
                        break;
                    case 2:
                        journal.DisplayJournal();
                        break;
                    case 3:
                        journal.SaveJournal();
                        break;
                    case 4:
                        journal.LoadJournal();
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}

class Journal
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();

    public void WriteNewEntry()
    {
        Console.WriteLine("Generating a random prompt...");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        JournalEntry newEntry = new JournalEntry(randomPrompt, response, date);
        journalEntries.Add(newEntry);

        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("Journal Entries:");
        foreach (var entry in journalEntries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter a file name to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    entry.SaveEntry(writer);
                }
            }

            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public void LoadJournal()
    {
        Console.Write("Enter a file name to load the journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            journalEntries.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length == 3)
                        {
                            string date = line[0];
                            string prompt = line[1];
                            string response = line[2];
                            JournalEntry loadedEntry = new JournalEntry(prompt, response, date);
                            journalEntries.Add(loadedEntry);
                        }
                    }
                }

                Console.WriteLine("Journal loaded from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    private string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}

class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public void SaveEntry(StreamWriter writer)
    {
        writer.WriteLine($"{Date},{Prompt},{Response}");
    }
}
