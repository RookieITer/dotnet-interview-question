using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@test.com" },
            new User { Id = 2, Name = "Bob", Email = "bob@test.com" },
            new User { Id = 1, Name = "Alice Updated", Email = "alice2@test.com" }
        };

        var result = Solve(users);

        foreach (var kv in result)
        {
            Console.WriteLine($"{kv.Key}: {kv.Value.Name} - {kv.Value.Email}");
        }
    }

    public static Dictionary<int, User> Solve(List<User> users)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}