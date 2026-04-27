public static List<CustomerOrderDto> Solve(List<Customer> customers, List<Order> orders)
{
    return customers
        .GroupJoin(
            orders,
            c => c.Id,
            o => o.CustomerId,
            (c, customerOrders) => new { Customer = c, Orders = customerOrders })
        .SelectMany(
            x => x.Orders.DefaultIfEmpty(),
            (x, o) => new CustomerOrderDto
            {
                CustomerName = x.Customer.Name,
                OrderId = o != null ? o.OrderId : 0,
                Amount = o != null ? o.Amount : 0
            })
        .ToList();
}