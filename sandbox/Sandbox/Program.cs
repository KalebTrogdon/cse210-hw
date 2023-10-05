using System;
using System.Text;

class PasswordGenerator
{
    private const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
    private const string DigitChars = "0123456789";
    private const string SpecialChars = "!@#$%^&*()-_=+[]{}|;:'\",.<>/?";

    public static string GeneratePassword(int length, bool useUppercase, bool useLowercase, bool useDigits, bool useSpecialChars)
    {
        StringBuilder password = new StringBuilder();
        string allChars = "";

        if (useUppercase) allChars += UppercaseChars;
        if (useLowercase) allChars += LowercaseChars;
        if (useDigits) allChars += DigitChars;
        if (useSpecialChars) allChars += SpecialChars;

        if (allChars == "")
        {
            Console.WriteLine("Please select at least one character type.");
            return "";
        }

        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            int index = random.Next(0, allChars.Length);
            password.Append(allChars[index]);
        }

        return password.ToString();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Password Generator");
        Console.WriteLine("===================");

        Console.Write("Enter password length: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Include uppercase letters? (y/n): ");
        bool useUppercase = Console.ReadLine().ToLower() == "y";

        Console.Write("Include lowercase letters? (y/n): ");
        bool useLowercase = Console.ReadLine().ToLower() == "y";

        Console.Write("Include digits? (y/n): ");
        bool useDigits = Console.ReadLine().ToLower() == "y";

        Console.Write("Include special characters? (y/n): ");
        bool useSpecialChars = Console.ReadLine().ToLower() == "y";

        string generatedPassword = GeneratePassword(length, useUppercase, useLowercase, useDigits, useSpecialChars);

        if (!string.IsNullOrEmpty(generatedPassword))
        {
            Console.WriteLine("Generated Password: " + generatedPassword);
        }
        else
        {
            Console.WriteLine("No password generated. Please select at least one character type.");
        }
    }
}
