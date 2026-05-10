<!-- Sync Impact Report: Version 1.0.0 (initial) - Added all principles and sections based on project context. Templates assumed aligned. -->
# RSS Feed Reader Constitution

## Core Principles

### I. Security-First Development
All code must adhere to secure coding practices. Validate all user inputs to prevent injection attacks. Use HTTPS for any network communications. Implement proper error handling to avoid information leakage. Regularly review code for common vulnerabilities.

### II. Maintainable Codebase
Follow clean architecture principles with clear separation of concerns. Backend (ASP.NET Core Web API) handles data logic, frontend (Blazor WebAssembly) manages UI. Use dependency injection, keep methods focused and small, and document all public APIs and interfaces.

### III. High Code Quality
Achieve high code quality through comprehensive testing. Write unit tests for all business logic with at least 80% code coverage. Follow C# coding standards, use async/await appropriately for asynchronous operations, and perform code reviews for all changes.

### IV. Cross-Platform Compatibility
Ensure the application runs seamlessly on Windows, macOS, and Linux. Use cross-platform .NET libraries and avoid platform-specific dependencies. Test on all target platforms before releases.

### V. Incremental Development
Develop features incrementally: Start with MVP (subscription management), then Extended-MVP (feed fetching). Avoid over-engineering by implementing only features required for the current phase. Defer complex features until proven necessary.

## Technology Stack Requirements

The application uses ASP.NET Core Web API for the backend and Blazor WebAssembly for the frontend. Backend manages subscription data and (in Extended-MVP) feed operations. Frontend provides the user interface for subscription management and display. Use C# throughout for consistency and code sharing. For Extended-MVP, integrate System.ServiceModel.Syndication for feed parsing and EF Core with SQLite for persistence if needed.

## Development Workflow

Focus on rapid development of the MVP: Add subscriptions by URL and display the list. Store data in memory only for simplicity. No feed fetching, validation, or persistence initially. After MVP completion, add manual refresh and item display for Extended-MVP. Use simple UI without polish. All changes must pass code reviews and maintain test coverage.

## Governance

This constitution supersedes all other project practices and guidelines. Amendments require approval from all stakeholders, documentation of changes, and a migration plan for existing code. All pull requests must verify compliance with these principles. Complexity must be justified against project goals. Use this constitution for guidance on development decisions.

**Version**: 1.0.0 | **Ratified**: 2026-05-03 | **Last Amended**: 2026-05-03
