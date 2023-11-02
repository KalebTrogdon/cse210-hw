using System;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Console.WriteLine($"You have {duration} seconds to list as many items as you can.\n");

        
        for (int i = 0; i < duration; i++)
        {
            
            Console.Write("Item: ");
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break; 
        }
        
        Console.WriteLine("You listed [Show item count here] items.");
        End();
    }
}
