// Entry point of the program
class Program
{
    static void Main()
    {
        // Create instances of the Fraction class
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(1, 3);

        // Create an instance of the FractionCalculator class
        FractionCalculator calculator = new FractionCalculator();

        // Perform arithmetic operations and display results
        Fraction sum = calculator.Add(fraction1, fraction2);
        Console.WriteLine("Sum: " + sum.GetFractionString());

        Fraction difference = calculator.Subtract(fraction1, fraction2);
        Console.WriteLine("Difference: " + difference.GetFractionString());

        Fraction product = calculator.Multiply(fraction1, fraction2);
        Console.WriteLine("Product: " + product.GetFractionString());

        try
        {
            Fraction quotient = calculator.Divide(fraction1, fraction2);
            Console.WriteLine("Quotient: " + quotient.GetFractionString());
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}