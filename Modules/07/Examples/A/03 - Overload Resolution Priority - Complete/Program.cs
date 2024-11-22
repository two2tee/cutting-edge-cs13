using System.Collections.Immutable;
using System.Runtime.CompilerServices;

ObjectHandler.Handle(["Booyah!", "Foobar"]);

class ObjectHandler
{
    [OverloadResolutionPriority(-1)]
    public static void Handle<T>(IEnumerable<T> elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }

    public static void Handle<T>(ImmutableArray<T> elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }

    [OverloadResolutionPriority(1)]
    public static void Handle<T>(params ReadOnlySpan<T> elements)
    {
        foreach (var element in elements)
        {
            Console.WriteLine(element);
        }
    }
}