using System;

namespace FunctionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the DisplayWelcome function
            DisplayWelcome();

            // Call the PromptUserName function to get the user's name
            string userName = PromptUserName();

            // Call the PromptUserNumber function to get the user's favorite number
            int userNumber = PromptUserNumber();

            // Call the SquareNumber function to calculate the square of the user's number
            int squaredNumber = SquareNumber(userNumber);

            // Call the DisplayResult function to display the user's name and squared number
            DisplayResult(userName, squaredNumber);
        }

        // Function to display a welcome message
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // Function to prompt the user for their name and return it as a string
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // Function to prompt the user for their favorite number and return it as an integer
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        // Function to calculate the square of an integer and return it
        static int SquareNumber(int number)
        {
            return number * number;
        }

        // Function to display the user's name and squared number
        static void DisplayResult(string name, int squaredNumber)
        {
            Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
        }
    }
}
