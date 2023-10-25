using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Math assignment
        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");

        // Create a Writing assignment
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        // Display summaries and additional information
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
