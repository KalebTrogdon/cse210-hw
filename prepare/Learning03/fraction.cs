using System; // Import necessary libraries for console input/output

// Define the Fraction class to represent fractions
public class Fraction
{
    // Private attributes to store the numerator and denominator
    private int numerator;
    private int denominator;

    // Constructor for creating a default fraction (1/1)
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor for creating a fraction with a given numerator
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1; // Denominator is set to 1 by default
    }

    // Constructor for creating a fraction with both numerator and denominator
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        numerator = top;
        denominator = bottom;
    }

    // Getter method to retrieve the numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter method to set the numerator
    public void SetNumerator(int top)
    {
        numerator = top;
    }

    // Getter method to retrieve the denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter method to set the denominator
    public void SetDenominator(int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = bottom;
    }

    // Method to get the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}