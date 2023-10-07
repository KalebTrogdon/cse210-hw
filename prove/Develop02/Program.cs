using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        bool isRunning = true;

        while (isRunning)
        {
            // Display the main menu for the journal program.
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
                        // Call the WriteNewEntry to add a new journal entry.
                        journal.WriteNewEntry();
                        break;
                    case 2:
                        // Call the DisplayJournal to display existing journal entries.
                        journal.DisplayJournal();
                        break;
                    case 3:
                        // Call the SaveJournal to save journal entries to a file.
                        journal.SaveJournal();
                        break;
                    case 4:
                        // Call the LoadJournal to load journal entries from a file.
                        journal.LoadJournal();
                        break;
                    case 5:
                        // Exit the program.
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
