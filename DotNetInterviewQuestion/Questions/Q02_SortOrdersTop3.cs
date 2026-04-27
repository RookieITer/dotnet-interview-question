using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerId = 101, Amount = 120.5, CreatedAt = new DateTime(2026, 4, 20) },
            new Order { OrderId = 2, CustomerId = 102, Amount = 300.0, CreatedAt = new DateTime(2026, 4, 21) },
            new Order { OrderId = 3, CustomerId = 103, Amount = 80.0, CreatedAt = new DateTime(2026, 4, 22) },
            new Order { OrderId = 4, CustomerId = 104, Amount = 500.0, CreatedAt = new DateTime(2026, 4, 23) }
        };

        var result = Solve(orders);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<Order> Solve(List<Order> orders)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public double Amount { get; set; }
    public DateTime CreatedAt { get; set; }
}