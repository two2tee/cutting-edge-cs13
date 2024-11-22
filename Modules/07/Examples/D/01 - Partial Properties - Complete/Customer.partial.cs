using System.Text.RegularExpressions;

namespace Wincubate.CS13.D;

// This is the "add-on" class

partial class Customer
{
    [GeneratedRegex("bygselv|pizza", RegexOptions.IgnoreCase)]
    private static partial Regex GetFoodPattern();

    public partial string FavoriteFood
    {
        get => _favoriteFood;
        set
        {
            if (GetFoodPattern().IsMatch(value.Replace("-", string.Empty)))
            {
                _favoriteFood = value;
                return;
            }

            throw new NotSupportedException("No way!");
        }
    }
    private string _favoriteFood = string.Empty;

    //partial void OnNameChanging(string newName)
    //{
    //    Console.WriteLine($"Changing \"{_name}\" to \"{newName}\"");
    //}

    //partial void OnNameChanged()
    //{
    //    Console.WriteLine($"Changed to \"{_name}\"");
    //}
}
