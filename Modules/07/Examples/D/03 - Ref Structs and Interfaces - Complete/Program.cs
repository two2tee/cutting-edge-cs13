Point3D point1 = new(1, 0, 1);
Point3D point2 = new(0, 2, 0);
Point3D point3 = new(3, 3, 0);

DisplayHelper.Display(point1);

interface IDisplayable
{
    void Display();
}

static class DisplayHelper
{
    public static void Display<T>(T displayable)
        where T : IDisplayable, allows ref struct
    {
        displayable.Display();
    }
}
