using System;

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