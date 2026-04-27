using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        List<Transaction> transactions = null;

        var result = Solve(transactions);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<AccountAmountSummaryDto> Solve(List<Transaction> transactions)
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

public class AccountAmountSummaryDto
{
    public string AccountNumber { get; set; }
    public double TotalAmount { get; set; }
}