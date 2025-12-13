# Contributing to JobForge

## Branching Strategy
- main: protected, production-ready code
- development: integration branch for upcoming work
- feature/*: short-lived branches from develop
- hotfix/*: emergency fixes from main

## Pull Requests
- Target develop unless releasing/hotfixing
- Small, focused changes
- Include description, rationale, and impact
- Link to relevant docs (contracts, ADRs)
- Require at least one review

## Code Standards
- .NET 9: SDK-style projects; minimal startup; health endpoints
- Angular 20: standalone APIs; Tailwind; environment configs only
- No shared DTO projects across services
- No cross-service DB queries

## CI Expectations
- Build + unit tests must pass
- Linting (TS, C#) and formatting via .editorconfig
- Security checks: no secrets in code; use Managed Identity + Key Vault
- PR validation: contracts schema changes must be reviewed

## Exposure & Security
- APIs reachable only through APIM
- Config via App Configuration + Key Vault references
- Retry and DLQ handling for workers
