public static Dictionary<int, User> Solve(List<User> users)
{
    var result = new Dictionary<int, User>();

    foreach (var user in users)
    {
        result[user.Id] = user;
    }

    return result;
}