public abstract class Goal
{
    private string name;
    private int points;

    public Goal(string name)
    {
        this.name = name;
        this.points = 0;
    }

    public void RecordEvent()
    {
        // Logic to record progress and update points
    }

    public abstract void DisplayProgress();
}
