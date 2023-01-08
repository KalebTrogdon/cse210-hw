using System;

internal class NewBaseType
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string F = Console.ReadLine();

        Console.Write("What is your last name? ");
        string L = Console.ReadLine();

        Console.WriteLine($"Your name is {L}, {F} {L}.");
    }
}