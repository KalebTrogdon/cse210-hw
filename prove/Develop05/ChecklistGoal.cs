using System;

public class ChecklistGoal : Goal
{
    private int singleEventPoints;
    private int targetEvents;
    private int bonusPoints;

    public ChecklistGoal(string name, int singleEventPoints, int targetEvents, int bonusPoints)
        : base(name, 500)
    {
        this.singleEventPoints = singleEventPoints;
        this.targetEvents = targetEvents;
        this.bonusPoints = bonusPoints;
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
        // Additional logic specific to ChecklistGoal progress display
    }
}
