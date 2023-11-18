public abstract class Goal
{
    private string name;
    protected int basePoints;  
    private int points;

    public string Name { get { return name; } }  

    public int BasePoints { get { return basePoints; } } // Added BasePoints property

    public Goal(string name, int basePoints)
    {
        this.name = name;
        this.basePoints = basePoints;
        this.points = 0;
    }

    public void RecordEvent()
    {
        // Logic to record progress and update points
        this.points += basePoints;
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"Progress for {Name}: {points} points");
    }
}
