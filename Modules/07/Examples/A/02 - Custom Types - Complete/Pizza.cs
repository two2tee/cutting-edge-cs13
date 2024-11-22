using System.Text;

record class Pizza
{
    private readonly SequencePacker<Topping> _toppings = [];

    public Pizza(params SequencePacker<Topping> toppings)
    {
        _toppings = toppings;
    }

    public void Add(Topping topping)
    {
        _toppings.Add(topping);
    }

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
