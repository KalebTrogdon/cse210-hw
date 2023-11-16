using System.Collections.Generic;

public class User
{
    private List<Goal> goals;
    private int totalPoints;

    public User()
    {
        this.goals = new List<Goal>();
        this.totalPoints = 0;
    }

    public void CreateGoal(Goal goal)
    {
        // Logic to add a new goal to the user's list
    }

    public void RecordEvent(Goal goal)
    {
        // Logic to record an event for a specific goal
    }

    public void DisplayGoals()
    {
        // Logic to display a list of user's goals and their progress
    }
}
