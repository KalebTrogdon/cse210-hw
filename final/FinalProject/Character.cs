// Character.cs
using System;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}\nHealth: {Health}");
    }

    public virtual void PerformAction()
    {
        Console.WriteLine($"{Name} performs a generic action.");
    }
}
