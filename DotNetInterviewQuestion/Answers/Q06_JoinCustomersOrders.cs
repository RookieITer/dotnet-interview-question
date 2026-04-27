public static List<CustomerOrderDto> Solve(List<Customer> customers, List<Order> orders)
{
    return customers
        .Join(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (c, o) => new CustomerOrderDto
            {
                CustomerName = c.Name,
                OrderId = o.OrderId,
                Amount = o.Amount
            })
        .ToList();
}