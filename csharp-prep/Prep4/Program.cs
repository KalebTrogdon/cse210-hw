using System;
using System.Collections.Generic;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            
            while (true)
            {
                Console.Write("Enter number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber == 0)
                {
                    break; // Exit the loop when the user enters 0
                }

                numbers.Add(inputNumber);
            }

            if (numbers.Count > 0)
            {
                // Core Requirement 1: Compute the sum of the numbers
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                }
                Console.WriteLine("The sum is: " + sum);

                // Core Requirement 2: Compute the average of the numbers
                double average = (double)sum / numbers.Count;
                Console.WriteLine("The average is: " + average);

                // Core Requirement 3: Find the maximum number in the list
                int max = numbers[0];
                foreach (int num in numbers)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                Console.WriteLine("The largest number is: " + max);
                
                // Stretch Challenge 1: Find the smallest positive number
                int smallestPositive = int.MaxValue;
                foreach (int num in numbers)
                {
                    if (num > 0 && num < smallestPositive)
                    {
                        smallestPositive = num;
                    }
                }
                if (smallestPositive != int.MaxValue)
                {
                    Console.WriteLine("The smallest positive number is: " + smallestPositive);
                }
                else
                {
                    Console.WriteLine("No positive numbers entered.");
                }

                // Stretch Challenge 2: Sort and display the list
                numbers.Sort();
                Console.WriteLine("The sorted list is:");
                foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("No numbers entered.");
            }
        }
    }
}
