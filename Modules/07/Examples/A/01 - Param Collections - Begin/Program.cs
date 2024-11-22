using System.Text;

Pizza meatLover = new(
    new List<Topping>
    {
        Topping.Beef,
        Topping.Kebab,
        Topping.Bacon
    }
);

//meatLover.Add(Topping.Jalapenos);

Console.WriteLine(meatLover);

record class Pizza
{
    private readonly List<Topping> _toppings = [];

    public Pizza(List<Topping> toppings)
    {        
        _toppings = toppings;
    }

    //public void Add(Topping kind)
    //{
    //    _toppings.Add(kind);
    //}

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Pizza with ");
        
        foreach (Topping topping in _toppings)
        {
            sb.AppendLine($"\t{topping}");
        }

        sb.AppendLine("with oregano on top");

        return sb.ToString();
    }
}
