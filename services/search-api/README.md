# Search API

## Responsibilities
- Provide full-text search capabilities for job postings
- Interface with Azure Cognitive Search
- Handle search queries, filters, and faceting
- Consume JobIndexed events from indexer-worker

## Boundaries
- No database; relies on Azure Cognitive Search
- Read-only operations (indexing done by indexer-worker)
- Exposed only via Azure API Management (APIM)

## Endpoints
- `GET /health` - Health check endpoint
- `GET /api/search?query={q}` - Search jobs by query (placeholder)
- `GET /api/search/filters` - Get available filters (TODO)
- `POST /api/search/advanced` - Advanced search with filters (TODO)

## Configuration
- Uses Azure App Configuration for centralized config
- Azure Cognitive Search connection uses Managed Identity
- No secrets in code

## Running Locally
```bash
cd services/search-api
dotnet restore
dotnet run
```

Access at: https://localhost:5002

## Dependencies
- .NET 9.0
- Azure App Configuration (TODO)
- Azure Cognitive Search SDK (TODO)
- Azure Key Vault (TODO)
