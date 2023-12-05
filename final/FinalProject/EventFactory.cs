using System;

public static class EventFactory
{
    public static OutcomeEvent GenerateRandomOutcome()
    {
        // Generate a random witty joke
        string[] wittyJokes = { "Joke A", "Joke B", "Joke C", /*...*/ };
        Random random = new Random();
        string randomJoke = wittyJokes[random.Next(wittyJokes.Length)];

        // Return a new WittyJokeEvent with the random joke
        return new WittyJokeEvent { Description = "You made a choice.", WittyJoke = randomJoke };
    }
}
