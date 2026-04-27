public static List<UserDto> Solve(List<User> users)
{
    return users
        .Where(u => u.IsActive)
        .Select(u => new UserDto
        {
            Name = u.Name,
            Email = u.Email
        })
        .ToList();
}