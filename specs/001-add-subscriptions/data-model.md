# Data Model: Add Subscriptions

## Entities

- **Subscription**: Represents a feed subscription entry.
- **SubscriptionList**: Represents the current set of subscriptions displayed to the user.

## Subscription

| Field | Type | Required | Description |
|-------|------|----------|-------------|
| `id` | `Guid` or `int` | Yes | Unique identifier for the subscription entry. |
| `url` | `string` | Yes | The RSS/Atom feed URL entered by the user. |
| `addedAt` | `DateTime` | Yes | Timestamp when the subscription was created. |

### Validation Rules

- `url` must be present and non-empty.
- URL format validation is intentionally deferred for MVP.
- Duplicate detection is out of scope for MVP; duplicate entries may appear.

## Relationships

- A `SubscriptionList` contains zero or more `Subscription` entries.
- There are no complex entity relationships in MVP: the model is a flat list.

## State Transitions

- `Empty` → `HasSubscriptions` when the first `Subscription` is added.
- `HasSubscriptions` → `HasSubscriptions` as additional subscriptions are added.
- There is no delete or update transition in MVP.

## API Models

### AddSubscriptionRequest

```json
{
  "url": "https://example.com/feed"
}
```

### SubscriptionDto

```json
{
  "id": "6d8f56d2-1f5c-4a88-8f1b-2b4f4a4c9d77",
  "url": "https://example.com/feed",
  "addedAt": "2026-05-16T12:00:00Z"
}
```

### SubscriptionListResponse

```json
[
  {
    "id": "...",
    "url": "https://example.com/feed",
    "addedAt": "2026-05-16T12:00:00Z"
  }
]
```

## UI Model

- Input field bound to `newSubscriptionUrl`.
- Action button triggers `AddSubscriptionRequest` to backend.
- List view bound to `SubscriptionListResponse`.

## Notes

- The chosen model is intentionally simple to support the MVP scope.
- If Extended-MVP is implemented later, the model can grow to include title, latest fetch status, and item metadata.
