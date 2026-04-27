public static List<LargestTransactionDto> Solve(List<Transaction> transactions)
{
    return transactions
        .GroupBy(t => t.AccountNumber)
        .Select(g => g.OrderByDescending(x => x.Amount).First())
        .Select(t => new LargestTransactionDto
        {
            AccountNumber = t.AccountNumber,
            TransactionId = t.TransactionId,
            Amount = t.Amount
        })
        .ToList();
}