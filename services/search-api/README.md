# Search API

Responsibilities:
- Query indexed jobs via Azure Cognitive Search.
Boundaries:
- Read-only access to search index; no direct DB cross-service queries.
- Exposed only via APIM.

Endpoints:
- GET /health
- GET /api/search?q=...
