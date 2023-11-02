using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
        }
        End();
    }
}
