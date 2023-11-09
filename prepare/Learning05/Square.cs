public class Square : Shape
{
    private float Side { get; set; }

    public Square(string color, float side) : base(color)
    {
        Side = side;
    }

    public override float GetArea()
    {
        // Calculate the area of a square
        return Side * Side;
    }
}
