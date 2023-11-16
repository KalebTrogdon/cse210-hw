public class ChecklistGoal : Goal
{
    private int singleEventPoints;
    private int targetEvents;
    private int bonusPoints;

    public ChecklistGoal(string name, int singleEventPoints, int targetEvents, int bonusPoints)
        : base(name)
    {
        this.singleEventPoints = singleEventPoints;
        this.targetEvents = targetEvents;
        this.bonusPoints = bonusPoints;
    }

    public override void DisplayProgress()
    {
        // Logic to display progress for checklist goals
    }
}
