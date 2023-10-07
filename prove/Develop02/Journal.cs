using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();

    public void WriteNewEntry()
    {
        // Generate a random prompt for the new journal entry.
        Console.WriteLine("Generating a random prompt...");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Create a new JournalEntry and add it to the journalEntries list.
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

        // Display all existing journal entries.
        Console.WriteLine("Journal Entries:");
        foreach (var entry in journalEntries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveJournal()
    {
        // Prompt the user to enter a file name to save the journal.
        Console.Write("Enter a file name to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            // Create a StreamWriter to write journal entries to the specified file.
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    // Call the SaveEntry method of each entry to save it to the file.
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
        // Prompt the user to enter a file name to load the journal.
        Console.Write("Enter a file name to load the journal: ");
        string fileName = Console.ReadLine();

        if (File.Exists(fileName))
        {
            journalEntries.Clear();

            try
            {
                // Read journal entries from the specified file and add them to the list.
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
        // Array of prompts for generating random prompts.
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Generate a random index and return a random prompt.
        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}

