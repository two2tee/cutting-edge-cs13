Thingy thingy = new()
{
    Elements =
    {
        [0] = "Hello",
        [1] = "World",
        [2] = "Booyah!",
        [3] = "Foobar"
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

