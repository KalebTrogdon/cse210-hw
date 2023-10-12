// Define the FractionCalculator class to perform arithmetic operations
public class FractionCalculator
{
    // Method to add two fractions
    public Fraction Add(Fraction fraction1, Fraction fraction2)
    {
        int newNumerator = (fraction1.GetNumerator() * fraction2.GetDenominator()) + (fraction2.GetNumerator() * fraction1.GetDenominator());
        int newDenominator = fraction1.GetDenominator() * fraction2.GetDenominator();

        return new Fraction(newNumerator, newDenominator);
    }

    // Method to subtract two fractions
    public Fraction Subtract(Fraction fraction1, Fraction fraction2)
    {
        int newNumerator = (fraction1.GetNumerator() * fraction2.GetDenominator()) - (fraction2.GetNumerator() * fraction1.GetDenominator());
        int newDenominator = fraction1.GetDenominator() * fraction2.GetDenominator();

        return new Fraction(newNumerator, newDenominator);
    }

    // Method to multiply two fractions
    public Fraction Multiply(Fraction fraction1, Fraction fraction2)
    {
        int newNumerator = fraction1.GetNumerator() * fraction2.GetNumerator();
        int newDenominator = fraction1.GetDenominator() * fraction2.GetDenominator();

        return new Fraction(newNumerator, newDenominator);
    }

    // Method to divide two fractions
    public Fraction Divide(Fraction fraction1, Fraction fraction2)
    {
        if (fraction2.GetNumerator() == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        int newNumerator = fraction1.GetNumerator() * fraction2.GetDenominator();
        int newDenominator = fraction1.GetDenominator() * fraction2.GetNumerator();

        return new Fraction(newNumerator, newDenominator);
    }
}
