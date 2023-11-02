using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an activity (1-4): ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                break;
            }

            if (int.TryParse(choice, out int activityChoice) && activityChoice >= 1 && activityChoice <= 3)
            {
                Console.Write("Enter duration (in seconds): ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                {
                    MindfulnessActivity activity = null;

                    switch (activityChoice)
                    {
                        case 1:
                            activity = new BreathingActivity();
                            break;
                        case 2:
                            activity = new ReflectionActivity();
                            break;
                        case 3:
                            activity = new ListingActivity();
                            break;
                    }

                    if (activity != null)
                    {
                        activity.Start(duration);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid duration input. Please enter a valid number of seconds.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose an activity by entering a number (1-3) or Quit (4).");
            }
        }
    }
}
