using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var transactions = new List<Transaction>
        {
            new Transaction { TransactionId = 1, AccountNumber = "A100", Amount = 50 },
            new Transaction { TransactionId = 2, AccountNumber = "A100", Amount = 75 },
            new Transaction { TransactionId = 3, AccountNumber = "B200", Amount = 120 }
        };

        var result = Solve(transactions);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<AccountTransactionCountDto> Solve(List<Transaction> transactions)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class Transaction
{
    public int TransactionId { get; set; }
    public string AccountNumber { get; set; }
    public double Amount { get; set; }
}

public class AccountTransactionCountDto
{
    public string AccountNumber { get; set; }
    public int TransactionCount { get; set; }
}