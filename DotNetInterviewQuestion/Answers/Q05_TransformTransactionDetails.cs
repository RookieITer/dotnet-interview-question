public static List<Account> Solve(List<TransactionDetail> transactionDetails)
{
    return transactionDetails
        .GroupBy(t => t.AccountNumber)
        .Select(g => new Account
        {
            AccountNumber = g.Key,
            Transactions = g.Select(t => new Transaction
            {
                TransactionNumber = t.TransactionNumber,
                Amount = t.Amount
            }).ToList()
        })
        .ToList();
}