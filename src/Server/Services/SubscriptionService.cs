using System.Collections.Concurrent;
using Server.Models;

namespace Server.Services;

public class SubscriptionService
{
    private readonly ConcurrentDictionary<System.Guid, Subscription> _store = new();

    public IEnumerable<Subscription> GetAll()
    {
        return _store.Values.OrderBy(s => s.AddedAt);
    }

    public Subscription Add(string url)
    {
        var s = new Subscription
        {
            Id = System.Guid.NewGuid(),
            Url = url,
            AddedAt = System.DateTime.UtcNow
        };
        _store[s.Id] = s;
        return s;
    }
}
