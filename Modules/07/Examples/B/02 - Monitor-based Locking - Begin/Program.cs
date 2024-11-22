Lock l = new();

lock (l)
{
    //
    // Critical region...
    //
}

// Compiles to:

//bool lockTaken = false;
//try
//{
//    Monitor.Enter(l, ref lockTaken);

    //
    // Critical region...
    //

//}
//finally
//{
//    if (lockTaken)
//    {
//        Monitor.Exit(l);
//    }
//}