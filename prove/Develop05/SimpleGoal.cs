using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name) : base(name, 10)
    {
    }

    public override void DisplayProgress()
    {
        base.DisplayProgress();
        // Additional logic specific to SimpleGoal progress display
    }
}
