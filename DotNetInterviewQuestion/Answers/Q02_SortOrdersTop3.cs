public static List<Order> Solve(List<Order> orders)
{
    return orders
        .OrderByDescending(o => o.Amount)
        .Take(3)
        .ToList();
}