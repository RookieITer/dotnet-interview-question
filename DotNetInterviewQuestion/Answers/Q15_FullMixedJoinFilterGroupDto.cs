public static List<CustomerOrderSummaryDto> Solve(List<Customer> customers, List<Order> orders)
{
    return customers
        .Where(c => c.IsActive)
        .Join(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (c, o) => new
            {
                CustomerName = c.Name,
                Amount = o.Amount,
                CreatedAt = o.CreatedAt
            })
        .GroupBy(x => x.CustomerName)
        .Select(g => new CustomerOrderSummaryDto
        {
            CustomerName = g.Key,
            OrderCount = g.Count(),
            TotalAmount = g.Sum(x => x.Amount),
            LatestOrderDate = g.Max(x => x.CreatedAt)
        })
        .ToList();
}