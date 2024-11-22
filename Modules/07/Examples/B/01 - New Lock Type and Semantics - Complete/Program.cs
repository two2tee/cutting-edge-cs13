Lock l = new();

using (var scope = l.EnterScope())
{
    //
    // Critical region...
    //
}

