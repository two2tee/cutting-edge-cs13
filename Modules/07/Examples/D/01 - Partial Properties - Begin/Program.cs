using System;
using Wincubate.CS13.D;

Customer customer = new()
{
    Name = "Bruce Campbell"
};
customer.Name = "Saul Goodman";
Console.WriteLine($"The customer name is: {customer.Name}");
