string s1 = "VoksneIrereDividererIEnSkov";
string s2 = "Otto";
string s3 = "NotAPalindrome";

Console.WriteLine(IsPalindrome(s1));
Console.WriteLine(IsPalindrome(s2));
Console.WriteLine(IsPalindrome(s3));

static bool IsPalindrome(string s) =>
    s.ToLowerInvariant() switch
    {
        [] or [_] => true,
        [var head, .. var mid, var tail] when head == tail => IsPalindrome(mid),
        _ => false
    };
