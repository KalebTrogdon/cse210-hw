// Derived class for Mage
public class Mage : Character
{
    public int MagicPower { get; set; }

    // Constructor
    public Mage(string name, int health, int magicPower) : base(name, health)
    {
        MagicPower = magicPower;
    }

    // Override method for character action
    public override void PerformAction()
    {
        Console.WriteLine($"{Name} casts a powerful spell with magic power {MagicPower}!");
    }
}
