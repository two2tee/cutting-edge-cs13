Point3D point1 = new(1, 0, 1);
Point3D point2 = new(0, 2, 0);

point1.Display();
point2.Display();

//IDisplayable point3 = new Point3D(3, 3, 0);

interface IDisplayable
{
    void Display();
}

static class DisplayHelper
{
    public static void Display<T>(T displayable)
        where T : IDisplayable
    {
        IDisplayable d = displayable;
        d.Display();
    }
}
