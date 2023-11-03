using System;
using System.Threading;
using System.Diagnostics;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);

        var stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed.TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(4000);

            if (stopwatch.Elapsed.TotalSeconds >= duration)
                break;

            Console.WriteLine("Breathe out...");
            Thread.Sleep(4000);
        }

        stopwatch.Stop();
        End();
    }
}
