using System;

class Program
{
    static void Main()
    {
        // Implement the main program logic here

        // For example:
        User user = new User();
        Goal goal1 = new SimpleGoal("Run a Marathon", 1000);
        Goal goal2 = new EternalGoal("Read Scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend the Temple", 50, 10, 500);

        user.CreateGoal(goal1);
        user.CreateGoal(goal2);
        user.CreateGoal(goal3);

        // Simulate recording events
        user.RecordEvent(goal1);
        user.RecordEvent(goal2);
        user.RecordEvent(goal3);

        // Display goals and progress
        user.DisplayGoals();
    }
}
