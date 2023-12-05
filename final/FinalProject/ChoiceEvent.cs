using System;
using System.Collections.Generic;

public class ChoiceEvent : GameEvent
{
    public List<Choice> Choices { get; set; } = new List<Choice>();

    public override void Execute()
    {
        Console.WriteLine(Description);
        DisplayChoices();
        int choiceIndex = GetUserChoice();
        Choices[choiceIndex].Outcome.Execute();
    }

    private void DisplayChoices()
    {
        Console.WriteLine("Choose an option:");
        for (int i = 0; i < Choices.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Choices[i].Text}");
        }
    }

    private int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Choices.Count)
        {
            Console.WriteLine("Invalid choice. Please enter a valid number.");
        }
        return choice - 1;
    }
}
