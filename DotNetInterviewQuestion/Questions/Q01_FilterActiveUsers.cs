using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var users = new List<User>
        {
            new User { Id = 1, Name = "Alice", Email = "alice@test.com", IsActive = true },
            new User { Id = 2, Name = "Bob", Email = "bob@test.com", IsActive = false },
            new User { Id = 3, Name = "Cathy", Email = "cathy@test.com", IsActive = true }
        };

        var result = Solve(users);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<UserDto> Solve(List<User> users)
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
    public bool IsActive { get; set; }
}

public class UserDto
{
    public string Name { get; set; }
    public string Email { get; set; }
}