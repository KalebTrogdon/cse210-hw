using System;
using System.Threading;

class MindfulnessActivity
{
    protected string name;
    protected string description;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Start(int duration)
    {
        Console.WriteLine($"Starting {name} activity. {description}");
        Console.WriteLine($"Duration: {duration} seconds.");
        Console.WriteLine("Get ready to begin...\n");

        // Display spinning animation while waiting
        DisplaySpinner(duration);

        Console.WriteLine("\n"); // Add a newline for better formatting
    }

    public void End(int duration)
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine($"Duration: {duration} seconds");
        Thread.Sleep(3000);
    }

    // Helper method to display a spinning animation
    private static void DisplaySpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write("/"); Thread.Sleep(250);
            Console.Write("\b"); // Move the cursor back
            Console.Write("-"); Thread.Sleep(250);
            Console.Write("\b"); // Move the cursor back
            Console.Write("\\"); Thread.Sleep(250);
            Console.Write("\b"); // Move the cursor back
            Console.Write("|"); Thread.Sleep(250);
            Console.Write("\b"); // Move the cursor back
        }
    }
}
