public static List<AccountAmountSummaryDto> Solve(List<Transaction> transactions)
{
    if (transactions == null || !transactions.Any())
        return new List<AccountAmountSummaryDto>();

    return transactions
        .GroupBy(t => t.AccountNumber)
        .Select(g => new AccountAmountSummaryDto
        {
            AccountNumber = g.Key,
            TotalAmount = g.Sum(x => x.Amount)
        })
        .ToList();
}