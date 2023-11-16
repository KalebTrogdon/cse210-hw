public class SimpleGoal : Goal
{
    private int completionPoints;

    public SimpleGoal(string name, int completionPoints)
        : base(name)
    {
        this.completionPoints = completionPoints;
    }

    public override void DisplayProgress()
    {
        // Logic to display progress for simple goals
    }
}
