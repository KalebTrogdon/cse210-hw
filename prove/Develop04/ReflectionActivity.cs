using System;
using System.Threading;

class ReflectionActivity : MindfulnessActivity
{
    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);

        // Reflection activity specific code
        Console.WriteLine("Selecting a random prompt...");

        // Simulated reflection process
        for (int i = 1; i <= duration; i++)
        {
            Console.WriteLine($"Reflecting question {i}...");
            Thread.Sleep(3000); // Simulated pause for reflection question
        }
    }

    public new void End(int duration)
    {
        base.End(duration); // Call the base class End method
    }
}
