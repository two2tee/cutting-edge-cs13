Lock l = new();
//object l = new Lock(); <-- Issues warning

lock (l)
{
    //
    // Critical region...
    //
}

// Compiles to:

//var scope;
//try
//{
//    scope = l.EnterScope();

    //
    // Critical region...
    //

//}
//finally
//{
//   scope.Dispose();
//}