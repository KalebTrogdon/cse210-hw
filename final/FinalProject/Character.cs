using System;

// Base class for characters
public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    // Constructor
    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }

    // Method to display character information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}\nHealth: {Health}");
    }

    // Base method for character action
    public virtual void PerformAction()
    {
        Console.WriteLine($"{Name} performs a generic action.");
    }
}
