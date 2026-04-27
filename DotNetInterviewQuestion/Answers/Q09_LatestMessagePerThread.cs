public static List<LatestThreadMessageDto> Solve(List<Message> messages)
{
    return messages
        .GroupBy(m => m.ThreadId)
        .Select(g => g.OrderByDescending(x => x.CreatedAt).First())
        .Select(m => new LatestThreadMessageDto
        {
            ThreadId = m.ThreadId,
            AuthorName = m.AuthorName,
            Content = m.Content,
            CreatedAt = m.CreatedAt
        })
        .ToList();
}