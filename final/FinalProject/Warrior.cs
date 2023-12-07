// Derived class for Warrior
public class Warrior : Character
{
    public int Strength { get; set; }

    // Constructor
    public Warrior(string name, int health, int strength) : base(name, health)
    {
        Strength = strength;
    }

    // Override method for character action
    public override void PerformAction()
    {
        Console.WriteLine($"{Name} swings their sword with strength {Strength}!");
    }
}
