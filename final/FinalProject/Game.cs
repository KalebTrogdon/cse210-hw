using System;
using System.Collections.Generic;

// Game class to manage the overall game flow
public class Game
{
    public List<Character> Characters { get; set; }

    // Constructor
    public Game()
    {
        Characters = new List<Character>();
    }

    // Method to add characters to the game
    public void AddCharacter(Character character)
    {
        Characters.Add(character);
    }

    // Method to display information about all characters
    public void DisplayCharactersInfo()
    {
        foreach (var character in Characters)
        {
            character.DisplayInfo();
            Console.WriteLine();
        }
    }

    // Method to simulate the game's progression
    public void PlayGame()
    {
        Console.WriteLine("Welcome to Chronicles of the Lost Realm!\n");

        foreach (var character in Characters)
        {
            character.PerformAction();
        }

        // Branching scenario
        Console.WriteLine("\nYou find yourself at a crossroads. What will you do?");
        DisplayChoices();

        int userChoice;
        while (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 10)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 10.");
        }

        // Handle user's choice
        ProcessUserChoice(userChoice);
    }

    // Display available choices
    private void DisplayChoices()
    {
        Console.WriteLine("1. Explore the dark forest.");
        Console.WriteLine("2. Enter the mysterious cave.");
        Console.WriteLine("3. Head towards the ancient ruins.");
        Console.WriteLine("4. Climb the mountain path.");
        Console.WriteLine("5. Take a detour through the swamp.");
        Console.WriteLine("6. Investigate the abandoned village.");
        Console.WriteLine("7. Follow the river downstream.");
        Console.WriteLine("8. Ascend the hidden staircase.");
        Console.WriteLine("9. Cross the bridge to the enchanted land.");
        Console.WriteLine("10. Rest and camp for the night.");
    }

    // Process user's choice
    private void ProcessUserChoice(int userChoice)
    {
        switch (userChoice)
        {
            case 1:
                Console.WriteLine("You venture into the dark forest and encounter a hidden treasure!");
                break;
            case 2:
                Console.WriteLine("You enter the mysterious cave and face a fierce monster!");
                break;
            case 3:
                Console.WriteLine("You explore the ancient ruins and discover a forgotten artifact!");
                break;
            case 4:
                Console.WriteLine("You climb the mountain path and witness a breathtaking view!");
                break;
            case 5:
                Console.WriteLine("You take a detour through the swamp and encounter mysterious creatures!");
                break;
            case 6:
                Console.WriteLine("You investigate the abandoned village and find a helpful ally!");
                break;
            case 7:
                Console.WriteLine("You follow the river downstream and discover a hidden waterfall!");
                break;
            case 8:
                Console.WriteLine("You ascend the hidden staircase and reach a magical realm!");
                break;
            case 9:
                Console.WriteLine("You cross the bridge to the enchanted land and meet mystical beings!");
                break;
            case 10:
                Console.WriteLine("You rest and camp for the night, rejuvenating your energy.");
                break;
        }
    }
}
