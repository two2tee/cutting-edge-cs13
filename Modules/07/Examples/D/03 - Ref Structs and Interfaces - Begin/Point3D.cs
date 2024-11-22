ref struct Point3D(double x, double y, double z) : IDisplayable
{
    public double X { get; } = x;
    public double Y { get; } = y;
    public double Z { get; } = z;

    public override readonly string ToString() => $"({X},{Y},{Z})";

    public readonly void Display()
    {
        Console.WriteLine(ToString());
    }
}
