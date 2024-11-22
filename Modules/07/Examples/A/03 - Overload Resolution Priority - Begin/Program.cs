ObjectHandler.Handle(new[] { "Booyah!", "Foobar" });

class ObjectHandler
{
    public static void Handle<T>(IEnumerable<T> elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }

    // TODO: ImmutableArray in next library revision
}