
// Solution: Collection Expressions

static List<int> Merge(List<int> list1, List<int> list2, List<int> acc) =>
    (list1, list2) switch
    {
        ([], []) => acc,
        ([], [var h, .. var t]) => Merge(list1, t, [h, .. acc]),
        ([var h, .. var t], []) => Merge(t, list2, [h, .. acc]),
        ([var h1, .. var t1], [var h2, .. var t2]) when h1 <= h2 => Merge(t1, list2, [h1, .. acc]),
        ([var h1, .. var t1], [var h2, .. var t2]) => Merge(list1, t2, [h2, .. acc])
    };



// Test:

List<int> elements1 = [11, 22, 44, 77, 99];
List<int> elements2 = [33, 44, 55, 66, 88, 99];
List<int> expected = [11, 22, 33, 44, 44, 55, 66, 77, 88, 99, 99];


IEnumerable<int> result = Merge(elements1, elements2, [])
    .AsEnumerable()
    .Reverse();

foreach (int i in result)
{
    Console.Write($"{i} ");
}

Console.WriteLine(result.SequenceEqual(expected)
    ? "\n\nTest passed!"
    : "\n\nTest failed!"
);