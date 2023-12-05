using System;

public class WittyJokeEvent : OutcomeEvent
{
    public string WittyJoke { get; set; }

    public override void Execute()
    {
        base.Execute();
        Console.WriteLine(WittyJoke);
    }
}
