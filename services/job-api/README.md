# Job API

Responsibilities:
- Manage job entities and lifecycle.
- Publish JobFetched events after ingestion triggers.
Boundaries:
- Own database; no cross-service queries.
- Exposed only via APIM.

Endpoints:
- GET /health
- GET /api/jobs (placeholder)
