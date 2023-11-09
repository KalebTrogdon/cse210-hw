public class Circle : Shape
{
    private float Radius { get; set; }

    public Circle(string color, float radius) : base(color)
    {
        Radius = radius;
    }

    public override float GetArea()
    {
        // Calculate the area of a circle
        return (float)(Math.PI * Radius * Radius);
    }
}
