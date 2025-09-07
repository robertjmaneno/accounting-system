Repository layout

This repo follows a conventional .NET layout:

- src/  — all production projects (e.g. src/Accounting.API)
- tests/ — test projects
- Accounting.API.sln at the repository root

Quick build (PowerShell)

When running `dotnet` from PowerShell, quote the console logger parameters so PowerShell does not treat `;` as a command separator. Example:

```powershell
# build the solution from repo root (PowerShell-safe)
dotnet build "C:\Users\rober\Documents\personal_projects\AccountingSystem\Accounting.API.sln" /property:GenerateFullPaths=true "/consoleloggerparameters:NoSummary;ForceNoAlign"
```

If you prefer, use the VS Code task `build` which already passes the parameter as a single arg and won't trigger the PowerShell split.

Notes

- Build in your paste actually succeeded: "Build succeeded" was reported. The subsequent error is PowerShell trying to execute the token `ForceNoAlign` because the semicolon was unquoted.
- Keep using the repo-root solution and the `src/` layout; it's the recommended structure.
