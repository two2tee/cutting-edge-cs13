Thingy thingy = new()
{
    Elements =
    {
        [^2] = "Hello",
        [^1] = "World",
        [0] = "Booyah!",
        [1] = "Foobar"
    }
};

thingy.Print();

class Thingy
{
    public string?[] Elements { get; set; } = new string?[4];

    public void Print()
    {
        foreach (var e in Elements)
        {
            Console.WriteLine(e);
        }
    }
}

