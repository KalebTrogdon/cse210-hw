using System;

public class Game
{
    public GameEvent CurrentEvent { get; set; }

    public void StartGame()
    {
        Console.WriteLine("Welcome to the Grand Adventure!\n");

        // Set up the initial game events
        GameEvent introEvent = new GameEvent
        {
            Description = "You wake up in a magical realm. What will you do?"
        };

        // ...

        // Create a loop for 40 choices
        for (int i = 0; i < 40; i++)
        {
            ChoiceEvent choiceEvent = new ChoiceEvent
            {
                Description = $"Choice {i + 1}: What path will you take?",
                Choices = new List<Choice>
                {
                    new Choice { Text = "Option A", Outcome = EventFactory.GenerateRandomOutcome() },
                    new Choice { Text = "Option B", Outcome = EventFactory.GenerateRandomOutcome() },
                    // ... Add more choices
                }
            };

            // Set the current event to the choice event
            CurrentEvent = choiceEvent;

            // Execute the choice event
            CurrentEvent.Execute();
        }
    }
}
