// Warrior.cs
public class Warrior : Character
{
    public int Strength { get; set; }

    public Warrior(string name, int health, int strength) : base(name, health)
    {
        Strength = strength;
    }

    public override void PerformAction()
    {
        Console.WriteLine($"{Name} swings their sword with strength {Strength}!");
    }
}
