public class Rectangle : Shape
{
    private float Length { get; set; }
    private float Width { get; set; }

    public Rectangle(string color, float length, float width) : base(color)
    {
        Length = length;
        Width = width;
    }

    public override float GetArea()
    {
        // Calculate the area of a rectangle
        return Length * Width;
    }
}
