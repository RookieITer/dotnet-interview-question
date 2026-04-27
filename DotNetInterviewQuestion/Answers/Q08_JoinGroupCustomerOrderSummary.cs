public static List<CustomerOrderSummaryDto> Solve(List<Customer> customers, List<Order> orders)
{
    return customers
        .Join(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (c, o) => new { c.Name, o.Amount })
        .GroupBy(x => x.Name)
        .Select(g => new CustomerOrderSummaryDto
        {
            CustomerName = g.Key,
            OrderCount = g.Count(),
            TotalAmount = g.Sum(x => x.Amount)
        })
        .ToList();
}