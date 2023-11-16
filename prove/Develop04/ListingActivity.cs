using System;
using System.Threading;

class ListingActivity : MindfulnessActivity
{
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Start(int duration)
    {
        base.Start(duration);

        // Listing activity specific code
        Console.WriteLine("Selecting a random prompt...");

        // Simulated listing process
        for (int i = 1; i <= duration; i++)
        {
            Console.WriteLine($"Listing item {i}...");
            Thread.Sleep(3000); // Simulated pause for listing item
        }
    }

    public new void End(int duration)
    {
        base.End(duration); // Call the base class End method
    }
}
