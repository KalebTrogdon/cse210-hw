public class Shape
{
    public string Color { get; set; }

    public Shape(string color)
    {
        Color = color;
    }

    public virtual float GetArea()
    {
        // The base class implementation doesn't provide a specific area calculation
        return 0.0f;
    }
}
