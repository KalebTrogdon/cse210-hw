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
        Thread.Sleep(3000);
    }

    public void End()
    {
        Console.WriteLine("Good job! You've completed the activity.");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine("Duration: [Show duration here]");
        Thread.Sleep(3000);
    }
}
