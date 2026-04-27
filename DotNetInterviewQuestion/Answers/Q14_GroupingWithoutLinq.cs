public static List<Account> Solve(List<TransactionDetail> transactionDetails)
{
    var accountMap = new Dictionary<string, Account>();

    foreach (var detail in transactionDetails)
    {
        if (!accountMap.ContainsKey(detail.AccountNumber))
        {
            accountMap[detail.AccountNumber] = new Account
            {
                AccountNumber = detail.AccountNumber,
                Transactions = new List<Transaction>()
            };
        }

        accountMap[detail.AccountNumber].Transactions.Add(new Transaction
        {
            TransactionNumber = detail.TransactionNumber,
            Amount = detail.Amount
        });
    }

    return accountMap.Values.ToList();
}