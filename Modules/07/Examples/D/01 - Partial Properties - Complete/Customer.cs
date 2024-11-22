namespace Wincubate.CS13.D;

// This is the main customer class
partial class Customer
{
    private string _name = string.Empty;

    public partial string FavoriteFood { get; set; }

    public string Name
    {
        get { return _name; }
        set
        {
            OnNameChanging(value);
            _name = value;
            OnNameChanged();
        }
    }

    partial void OnNameChanging(string newName);
    partial void OnNameChanged();
}
