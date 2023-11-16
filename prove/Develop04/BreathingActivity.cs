using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);

        // Breathing activity specific code
        Console.WriteLine("Breathe in...");
        Thread.Sleep(3000); // Simulated "Breathe in" for 3 seconds
        Console.WriteLine("Breathe out...");
        Thread.Sleep(3000); // Simulated "Breathe out" for 3 seconds
    }
}
