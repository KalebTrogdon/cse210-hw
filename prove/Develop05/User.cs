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
        goals.Add(goal);
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        totalPoints += goal.BasePoints; // Use the BasePoints property
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }

        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public Goal GetGoalByName(string goalName)
    {
        return goals.Find(g => g.Name.Equals(goalName, StringComparison.OrdinalIgnoreCase));
    }
}
