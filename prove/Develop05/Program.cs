using System;

class Program
{
    static void Main()
    {
        User user = new User();
        Goal simpleGoal1 = new SimpleGoal("Read a chapter from the Book of Mormon daily");
        Goal simpleGoal2 = new SimpleGoal("Pray morning and night");
        Goal simpleGoal3 = new SimpleGoal("Attend sacrament meeting weekly");
        Goal simpleGoal4 = new SimpleGoal("Participate in family home evening weekly");
        Goal simpleGoal5 = new SimpleGoal("Share a scripture with someone each day");

        // Creating eternal goals
        Goal eternalGoal1 = new EternalGoal("Attend the temple monthly");
        Goal eternalGoal2 = new EternalGoal("Complete family history work for ancestors");
        Goal eternalGoal3 = new EternalGoal("Serve in a temple calling");
        Goal eternalGoal4 = new EternalGoal("Attend general conference sessions");
        Goal eternalGoal5 = new EternalGoal("Achieve a personal temple recommend");

        // Creating checklist goals
        Goal checklistGoal1 = new ChecklistGoal("Serve in a church calling", 50, 3, 200);
        Goal checklistGoal2 = new ChecklistGoal("Participate in a service project monthly", 30, 2, 100);
        Goal checklistGoal3 = new ChecklistGoal("Read a general conference talk weekly", 20, 4, 150);
        Goal checklistGoal4 = new ChecklistGoal("Invite a friend to church monthly", 40, 2, 120);
        Goal checklistGoal5 = new ChecklistGoal("Organize or participate in a ward activity", 60, 1, 180);

        // Adding goals to the user
        user.CreateGoal(simpleGoal1);
        user.CreateGoal(simpleGoal2);
        user.CreateGoal(simpleGoal3);
        user.CreateGoal(simpleGoal4);
        user.CreateGoal(simpleGoal5);

        user.CreateGoal(eternalGoal1);
        user.CreateGoal(eternalGoal2);
        user.CreateGoal(eternalGoal3);
        user.CreateGoal(eternalGoal4);
        user.CreateGoal(eternalGoal5);

        user.CreateGoal(checklistGoal1);
        user.CreateGoal(checklistGoal2);
        user.CreateGoal(checklistGoal3);
        user.CreateGoal(checklistGoal4);
        user.CreateGoal(checklistGoal5);

        while (true)
        {
            Console.WriteLine("==== Main Menu ====");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(user);
                    break;
                case "2":
                    RecordEvent(user);
                    break;
                case "3":
                    user.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine("Exiting program. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal(User user)
    {
        Console.WriteLine("==== Create Goal ====");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Enter the goal type: ");
        string goalType = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();

        Goal goal = null;

        switch (goalType)
        {
            case "1":
                goal = new SimpleGoal(goalName);
                break;
            case "2":
                goal = new EternalGoal(goalName);
                break;
            case "3":
                Console.Write("Enter single event points: ");
                int singleEventPoints = int.Parse(Console.ReadLine());

                Console.Write("Enter target events: ");
                int targetEvents = int.Parse(Console.ReadLine());

                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(goalName, singleEventPoints, targetEvents, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type. Returning to main menu.");
                return;
        }

        user.CreateGoal(goal);
        Console.WriteLine($"{goal.GetType().Name} '{goalName}' created successfully.");
    }

    static void RecordEvent(User user)
    {
        Console.WriteLine("==== Record Event ====");
        Console.Write("Enter the goal name: ");
        string goalName = Console.ReadLine();

        Goal goal = user.GetGoalByName(goalName);

        if (goal == null)
        {
            Console.WriteLine($"Goal '{goalName}' not found. Returning to main menu.");
            return;
        }

        user.RecordEvent(goal);
        Console.WriteLine($"Event recorded for {goal.GetType().Name} '{goalName}'.");
    }
}
