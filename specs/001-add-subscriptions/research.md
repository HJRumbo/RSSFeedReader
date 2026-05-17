# Research: Add Subscriptions

## Decision

Use an ASP.NET Core Web API backend with a Blazor WebAssembly frontend for the MVP, matching the existing repository TechStack guidance. The backend will manage subscription state in memory, and the frontend will provide a simple UI for adding a feed URL and viewing the subscription list.

## Rationale

- The documented TechStack already prioritizes ASP.NET Core Web API + Blazor WebAssembly, so this choice maximizes alignment and reduces upfront architecture risk.
- An in-memory store avoids persistence complexity for MVP while still allowing a clean API contract and frontend integration.
- Keeping feed fetching and parsing out of scope for MVP preserves the minimal proof-of-concept objective and reduces security surface area.
- Blazor WebAssembly enables a modern C# frontend experience without introducing a separate JavaScript framework.

## Alternatives Considered

- Pure client-side Blazor-only app: This would remove the backend but also remove the explicit API contract and reduce the demo value of the planned backend/frontend split.
- Adding persistence immediately: Rejected because the MVP requirement is proof-of-concept subscription management only and the project goals explicitly defer persistence.
- Validating feed URLs: Rejected for MVP because stakeholder documents assume valid input and validation would add unnecessary scope.

## Best Practices

- Keep the backend API surface minimal: one POST endpoint to add a subscription and one GET endpoint to retrieve subscriptions.
- Keep frontend interactions simple: input field + add button + subscription list display.
- Use dependency injection and small service classes on the backend to keep the design maintainable and testable.
- Keep the UI state in sync with the backend by loading the subscription list after each successful add.
