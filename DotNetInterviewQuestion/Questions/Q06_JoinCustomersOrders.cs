using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Alice" },
            new Customer { Id = 2, Name = "Bob" }
        };

        var orders = new List<Order>
        {
            new Order { OrderId = 101, CustomerId = 1, Amount = 120.5 },
            new Order { OrderId = 102, CustomerId = 1, Amount = 300.0 },
            new Order { OrderId = 103, CustomerId = 2, Amount = 80.0 }
        };

        var result = Solve(customers, orders);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<CustomerOrderDto> Solve(List<Customer> customers, List<Order> orders)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public double Amount { get; set; }
}

public class CustomerOrderDto
{
    public string CustomerName { get; set; }
    public int OrderId { get; set; }
    public double Amount { get; set; }
}