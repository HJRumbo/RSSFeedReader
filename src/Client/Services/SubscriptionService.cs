using System.Net.Http.Json;
using Client.Models;

namespace Client.Services;

public class SubscriptionService
{
    private readonly HttpClient _httpClient;

    public SubscriptionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<SubscriptionDto>> GetSubscriptionsAsync()
    {
        var subscriptions = await _httpClient.GetFromJsonAsync<IEnumerable<SubscriptionDto>>("api/subscriptions");
        return subscriptions ?? Enumerable.Empty<SubscriptionDto>();
    }

    public async Task<SubscriptionDto?> AddSubscriptionAsync(string url)
    {
        var response = await _httpClient.PostAsJsonAsync("api/subscriptions", new { url });
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<SubscriptionDto>();
    }
}
