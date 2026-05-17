namespace Client.Models;

public class SubscriptionDto
{
    public Guid Id { get; set; }
    public string Url { get; set; } = string.Empty;
    public DateTime AddedAt { get; set; }
}
