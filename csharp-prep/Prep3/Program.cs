using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                int magicNumber = GenerateRandomNumber(1, 100);
                int numberOfGuesses = 0;

                Console.WriteLine("Welcome to Guess My Number!");
                Console.WriteLine("I've selected a magic number between 1 and 100.");

                while (true)
                {
                    int userGuess = GetUserGuess();
                    numberOfGuesses++;

                    if (userGuess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine($"It took you {numberOfGuesses} guesses.");
                        break;
                    }
                }

                Console.Write("Do you want to play again? (yes/no): ");
                string playAgainResponse = Console.ReadLine().ToLower();

                if (playAgainResponse != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random randomGenerator = new Random();
            return randomGenerator.Next(min, max + 1);
        }

        static int GetUserGuess()
        {
            int userGuess;
            bool validInput;

            do
            {
                Console.Write("What is your guess? ");
                validInput = int.TryParse(Console.ReadLine(), out userGuess);

                if (!validInput)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (!validInput);

            return userGuess;
        }
    }
}
