// Mage.cs
public class Mage : Character
{
    public int MagicPower { get; set; }

    public Mage(string name, int health, int magicPower) : base(name, health)
    {
        MagicPower = magicPower;
    }

    public override void PerformAction()
    {
        Console.WriteLine($"{Name} casts a powerful spell with magic power {MagicPower}!");
    }
}
