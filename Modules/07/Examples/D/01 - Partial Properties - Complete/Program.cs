using Wincubate.CS13.D;

Customer customer = new()
{
    Name = "Bruce Campbell"
};
customer.Name = "Saul Goodman";
customer.FavoriteFood = "Byg-Selv";

Console.WriteLine($"The customer name is: {customer.Name} and enjoys {customer.FavoriteFood}");
