using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var messages = new List<Message>
        {
            new Message { MessageId = 1, ThreadId = 100, AuthorName = "Alice", Content = "Hi", CreatedAt = new DateTime(2026, 4, 20, 9, 0, 0) },
            new Message { MessageId = 2, ThreadId = 100, AuthorName = "Bob", Content = "Hello", CreatedAt = new DateTime(2026, 4, 20, 10, 0, 0) },
            new Message { MessageId = 3, ThreadId = 200, AuthorName = "Cathy", Content = "Morning", CreatedAt = new DateTime(2026, 4, 20, 8, 30, 0) }
        };

        var result = Solve(messages);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<LatestThreadMessageDto> Solve(List<Message> messages)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class Message
{
    public int MessageId { get; set; }
    public int ThreadId { get; set; }
    public string AuthorName { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}

public class LatestThreadMessageDto
{
    public int ThreadId { get; set; }
    public string AuthorName { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
}