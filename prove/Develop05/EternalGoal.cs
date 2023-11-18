using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name) : base(name, 1000)
    {
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
        // Additional logic specific to EternalGoal progress display
    }
}
