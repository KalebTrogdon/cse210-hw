using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Activities Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity (not implemented)");
            Console.WriteLine("3. Listing Activity (not implemented)");
            Console.WriteLine("4. Exit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformBreathingActivity();
                    break;
                case "2":
                    Console.WriteLine("Reflection Activity (not implemented)");
                    break;
                case "3":
                    Console.WriteLine("Listing Activity (not implemented)");
                    break;
                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void PerformBreathingActivity()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.Start(10); // Start the breathing activity for 10 seconds
        breathingActivity.End(10);
    }
}
