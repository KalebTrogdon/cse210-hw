using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.")
            // Add more scriptures as needed
        };

        foreach (Scripture scripture in scriptures)
        {
            Console.Clear();
            Console.WriteLine(scripture);

            while (!scripture.AllWordsHidden())
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    return;

                scripture.RemoveRandomWordAndLeaveFirstLetter();
                Console.Clear();
                Console.WriteLine(scripture);
            }
        }

        Console.WriteLine("All scriptures are memorized. Good job!");
    }
}

