# Tasks: Add Subscriptions

## Phase 1 — Setup

- [ ] T001 Create solution and project skeleton: `src/Server/Server.csproj` and `src/Client/Client.csproj`
- [ ] T002 Add repository-level README and feature entry in `README.md` pointing to `specs/001-add-subscriptions` 
- [ ] T003 Add CI/dev script placeholders: `scripts/restore.ps1` and `scripts/run-dev.ps1`

## Phase 2 — Foundational

- [ ] T004 [P] Implement `Subscription` model in `src/Server/Models/Subscription.cs`
- [ ] T005 [P] Implement `SubscriptionDto` in `src/Client/Models/SubscriptionDto.cs`
- [ ] T006 Implement in-memory subscription service `src/Server/Services/SubscriptionService.cs`
- [ ] T007 [P] Add API controller scaffold `src/Server/Controllers/SubscriptionsController.cs` (GET/POST stubs)
- [ ] T008 Add backend unit test project and initial tests in `tests/Server.Tests/SubscriptionServiceTests.cs`

## Phase 3 — User Stories (priority order)

### User Story 1 - Add a feed subscription (Priority: P1)

- [ ] T009 [US1] Implement `AddSubscriptionRequest` model in `src/Server/Models/AddSubscriptionRequest.cs`
- [ ] T010 [US1] Implement POST `/api/subscriptions` in `src/Server/Controllers/SubscriptionsController.cs` (return `201 Created` and created `SubscriptionDto`)
- [ ] T011 [US1] Implement client Add UI (input + Add button) in `src/Client/Pages/Index.razor`
- [ ] T012 [US1] Implement client service method to call POST in `src/Client/Services/SubscriptionService.cs`

### User Story 2 - View current subscriptions (Priority: P2)

- [ ] T013 [US2] Implement GET `/api/subscriptions` in `src/Server/Controllers/SubscriptionsController.cs`
- [ ] T014 [US2] Implement client subscription list rendering in `src/Client/Pages/Index.razor`
- [ ] T015 [US2] Map API response to UI model in `src/Client/Services/SubscriptionService.cs`

### User Story 3 - View empty state (Priority: P3)

- [ ] T016 [US3] Implement empty-state UI placeholder in `src/Client/Pages/Index.razor`
- [ ] T017 [US3] Add manual verification steps to `specs/001-add-subscriptions/quickstart.md` for empty-state and add-flow checks

## Final Phase — Polish & Cross-cutting

- [ ] T018 Update `README.md` and `.github/copilot-instructions.md` with run instructions and plan links
- [ ] T019 Add an integration smoke test or manual checklist in `tests/Integration/` to verify end-to-end add-and-list flow

## Dependencies

- Phase 1 tasks must complete before Phase 2 begins.
- Phase 2 (model + service) must be completed before POST/GET API endpoints are implemented in Phase 3.
- Client UI tasks can proceed in parallel with backend unit tests once API stubs are present.

## Parallel execution examples

- The following tasks are parallelizable and safe to run concurrently: `T004`, `T005`, `T007`, `T012`, `T015`.

## Independent test criteria (per user story)

- US1 (Add): Add a valid feed URL via UI and confirm it appears in the subscription list.
- US2 (View): Call GET `/api/subscriptions` and confirm the returned JSON matches the expected `SubscriptionDto` list; confirm the client renders the same list.
- US3 (Empty): Launch the app with no subscriptions and confirm the empty-state placeholder is visible.

## Suggested MVP scope

- Minimal MVP: implement `US1` (T009-T012) plus foundational tasks T004-T006 so the add flow works end-to-end in-memory. UI polish and persistence deferred to Extended-MVP.

## Notes

- All tasks include exact file paths to enable focused implementation. Tests are recommended (xUnit + bUnit) but minimal manual verification is acceptable for the MVP demo.
