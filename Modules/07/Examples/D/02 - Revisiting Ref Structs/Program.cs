Point3D point = new(1, 0, 1);
object o = point;

Console.WriteLine(o);


struct Point3D(double x, double y, double z)
{
    public double X { get; } = x;
    public double Y { get; } = y;
    public double Z { get; } = z;

    public override readonly string ToString() => $"({X},{Y},{Z})";
}
