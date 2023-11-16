public class EternalGoal : Goal
{
    private int eventPoints;

    public EternalGoal(string name, int eventPoints)
        : base(name)
    {
        this.eventPoints = eventPoints;
    }

    public override void DisplayProgress()
    {
        // Logic to display progress for eternal goals
    }
}
