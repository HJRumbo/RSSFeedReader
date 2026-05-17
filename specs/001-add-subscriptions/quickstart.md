# Quickstart: Add Subscriptions

## Prerequisites

- .NET SDK 8.0 or later installed
- A development environment capable of building ASP.NET Core and Blazor WebAssembly apps

## Recommended Project Layout

This feature is designed for a repository structure like:

```text
src/
├── Server/
└── Client/
```

- `Server/`: ASP.NET Core Web API backend project
- `Client/`: Blazor WebAssembly frontend project

## Running the MVP

1. Open the repository root in your terminal.
2. Restore packages:
   ```powershell
   dotnet restore
   ```
3. Start the backend API:
   ```powershell
   dotnet run --project src\Server\Server.csproj
   ```
4. Start the Blazor WebAssembly client:
   ```powershell
   dotnet run --project src\Client\Client.csproj
   ```
5. Open the app in the browser using the URL shown by the client project.

## What to Verify

- The app shows an input for a feed URL and an Add button.
- Entering a URL and submitting adds a subscription.
- The subscription list updates immediately and displays the new URL.
- An empty-state message appears if no subscriptions are present.

## Notes

- This quickstart assumes the implementation uses separate `Server` and `Client` projects.
- If the project is later merged into a single hosted solution, run the solution entry point instead of separate project commands.
- No feed loading or persistence is required for MVP; the data only lives in memory for the current session.
