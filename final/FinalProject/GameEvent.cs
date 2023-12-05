using System;

public class GameEvent
{
    public string Description { get; set; }

    public virtual void Execute()
    {
        Console.WriteLine(Description);
    }
}
