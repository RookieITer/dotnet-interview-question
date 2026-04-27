using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public class Program
{
    public static void Main()
    {
        var transactionDetails = new List<TransactionDetail>
        {
            new TransactionDetail { AccountNumber = "0001123456", TransactionNumber = 1, Amount = 1000 },
            new TransactionDetail { AccountNumber = "WRAP987654", TransactionNumber = 10, Amount = 30000 },
            new TransactionDetail { AccountNumber = "0001123456", TransactionNumber = 20, Amount = 200 }
        };

        var result = Solve(transactionDetails);

        Console.WriteLine(JsonSerializer.Serialize(result, new JsonSerializerOptions { WriteIndented = true }));
    }

    public static List<Account> Solve(List<TransactionDetail> transactionDetails)
    {
        // Code here
        throw new NotImplementedException();
    }
}

public class TransactionDetail
{
    public int TransactionNumber { get; set; }
    public string AccountNumber { get; set; }
    public double Amount { get; set; }
}

public class Account
{
    public string AccountNumber { get; set; }
    public List<Transaction> Transactions { get; set; }
}

public class Transaction
{
    public int TransactionNumber { get; set; }
    public double Amount { get; set; }
}