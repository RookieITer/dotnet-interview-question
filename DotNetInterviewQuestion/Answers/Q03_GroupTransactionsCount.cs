public static List<AccountTransactionCountDto> Solve(List<Transaction> transactions)
{
    return transactions
        .GroupBy(t => t.AccountNumber)
        .Select(g => new AccountTransactionCountDto
        {
            AccountNumber = g.Key,
            TransactionCount = g.Count()
        })
        .ToList();
}