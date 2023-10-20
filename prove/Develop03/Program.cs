using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture("Alma 32:42", "And because of your diligence and your faith and your patience with the word in nourishing it, that it may take root in you, behold, by and by ye shall pluck the fruit thereof, which is most precious, which is sweet above all that is sweet, and which is white above all that is white, yea, and pure above all that is pure; and ye shall feast upon this fruit even until ye are filled, that ye hunger not, neither shall ye thirst."),
            new Scripture("2 Nephi 2:25", "Adam fell that men might be, and men are, that they might have joy.")
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

        Console.WriteLine("All scriptures are memorized. You did it!");
    }
}

