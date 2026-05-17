# API Contract: Subscription Management

## Base path

`/api/subscriptions`

## Endpoints

### GET /api/subscriptions

Returns the current list of subscriptions.

**Response**

- Status: `200 OK`
- Content-Type: `application/json`
- Body: array of `SubscriptionDto`

```json
[
  {
    "id": "6d8f56d2-1f5c-4a88-8f1b-2b4f4a4c9d77",
    "url": "https://example.com/feed",
    "addedAt": "2026-05-16T12:00:00Z"
  }
]
```

### POST /api/subscriptions

Adds a new subscription.

**Request**

- Content-Type: `application/json`
- Body:

```json
{
  "url": "https://example.com/feed"
}
```

**Response**

- Status: `201 Created` on success
- Header: `Location` points to the created subscription resource (optional for MVP)
- Body: created `SubscriptionDto`

```json
{
  "id": "6d8f56d2-1f5c-4a88-8f1b-2b4f4a4c9d77",
  "url": "https://example.com/feed",
  "addedAt": "2026-05-16T12:00:00Z"
}
```

## Data Shapes

### SubscriptionDto

| Field | Type | Description |
|-------|------|-------------|
| `id` | `string` | Unique subscription identifier (GUID or integer). |
| `url` | `string` | The RSS/Atom feed URL. |
| `addedAt` | `string` | ISO 8601 timestamp when the subscription was added. |

### AddSubscriptionRequest

| Field | Type | Description |
|-------|------|-------------|
| `url` | `string` | The feed URL to subscribe to. |

## Notes

- Server-side storage is in-memory for MVP.
- URL validation is minimal: request must include a non-empty `url` string.
- Duplicate detection is out of scope for MVP; duplicate subscriptions may be returned.
