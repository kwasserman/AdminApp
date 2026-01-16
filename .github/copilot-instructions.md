# Copilot / Agent Instructions for AdminApp

Purpose: Provide quick, actionable context for an AI coding agent to be productive in this repo.

Quick architecture
- Desktop UI: classic WinForms app. Entry point: Program.cs starts `login` then `MenuForm`.
- Business layer: `AdminBL/AdminBL.cs` implements `IAdminBL` and expects a repository via constructor DI.
- Data layer: intended repository pattern (`DL/IRepository.cs`) with a concrete `DL/SQLRepository.cs` and a `AdminSetting/ConnectionSettings.cs` helper that manages a raw `MySqlConnection`.
- Misc: `Controllers/LoginController.cs` is an ASP.NET-style controller present in the codebase (likely for future/alternate Web API usage) — treat it as an integration point, not the WinForms runtime path.

Key files to inspect
- [Program.cs](Program.cs)
- [login.cs](login.cs)
- [MenuForm.cs](MenuForm.cs)
- [AdminBL/AdminBL.cs](AdminBL/AdminBL.cs)
- [DL/IRepository.cs](DL/IRepository.cs)
- [DL/SQLRepository.cs](DL/SQLRepository.cs)
- [AdminSetting/ConnectionSettings.cs](AdminSetting/ConnectionSettings.cs)
- [AdminModels/UsersModels.cs](AdminModels/UsersModels.cs)
- [Controllers/LoginController.cs](Controllers/LoginController.cs)
- [appsettings.json](appsettings.json) — contains Auth0 config (secrets present).

Project-specific patterns & notes
- WinForms first: The primary runtime is desktop WinForms. Changes must preserve current startup flow (`Program.cs` uses `Application.Run`).
- Constructor DI is used in business/controller layers (see `AdminBL` and `LoginController`). Respect those constructors when refactoring.
- Database access: `ConnectionSettings` centralizes low-level MySQL calls and exposes `ExecuteReader` / `ExecuteNonQuery`. `SQLRepository` currently creates `MySqlCommand` objects directly and does not show explicit connection open/close in its method body — review carefully before changing DB code.
- Models use static backing fields (see `AdminModels/UsersModels.cs`) — this is a project-specific pattern that makes model instances share state; be cautious changing to instance-backed properties without understanding downstream effects.
- Logging: Serilog is initialized in `Program.cs` to write to `logs/events.txt`. Use `Log.Information(...)` to keep consistent logging.
- Config: `appsettings.json` holds Auth0 keys/secret. Treat these as sensitive; do not hardcode or commit new secrets. Prefer to use environment variables or a secure store if adding credentials.

> Known inconsistencies an agent should not silently fix
- `DL/IRepository.cs` defines `GetAllUsers()` but `DL/SQLRepository.cs` does not implement the `IRepository` interface — any automated refactor that assumes correct interface wiring may break runtime behavior.
- `SQLRepository.GetAllUsers()` constructs `MySqlCommand`/`MySqlDataReader` but lacks an explicit opened connection in the method body; `ConnectionSettings` provides connection management elsewhere — reconcile before changing.

Developer workflows (explicit commands)
- Build: `dotnet build AdminApp.sln`
- Publish: `dotnet publish AdminApp.sln`
- Run with file-watch: `dotnet watch run --project AdminApp.sln`
- VS Code tasks available: `build`, `publish`, `watch` (see workspace tasks in launch/task configuration).

Integration points
- MySQL: `AdminSetting/ConnectionSettings.cs` — raw SQL strings used across the project.
- Auth0: `appsettings.json` contains Auth0 ClientId/Secret/Domain used by `Application/*` files.
- Serilog file sink: `logs/events.txt` is used for local runtime logs.

Do/don't checklist for automated changes
- Do: Keep UI behavior intact (startup/login flow) and preserve constructor DI signatures.
- Do: Reference `ConnectionSettings` when changing DB access; prefer to centralize connection open/close.
- Do: Keep Serilog usage and existing log file path unless explicitly asked to change logging configuration.
- Don't: Replace static model fields or database credential handling without explicit review and tests.
- Don't: Commit secrets in `appsettings.json` or new copies of credentials.

If uncertain, inspect these examples before modifying code
- Startup/login flow: [Program.cs](Program.cs) — see how `login` and `MenuForm` are invoked.
- Business-to-data call: `AdminBL.AdminBL.GetAllUsers()` -> `IRepository.GetAllUsers()` -> expected `SQLRepository` implementation.
- Connection helper: `AdminSetting/ConnectionSettings.cs` for how DB is opened/used.

Next steps for the agent
- When requested to change DB code: run local build first, then add small, tested changes to one repository method.
- Ask the repository owner before altering `appsettings.json` or secret handling.

If any area above is unclear or you want the instructions expanded (e.g., exact locations to run, tests to add, or DI wiring to adjust), tell me which section to expand.
