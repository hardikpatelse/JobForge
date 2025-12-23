# Job API

## Responsibilities
- Manage job entities and lifecycle
- Publish JobFetched events after ingestion triggers
- Provide CRUD operations for job postings
- Expose job data through REST endpoints

## Boundaries
- Own database (JobsDatabase)
- No cross-service DB queries
- Exposed only via Azure API Management (APIM)

## Endpoints
- `GET /health` - Health check endpoint
- `GET /api/jobs` - List all jobs (placeholder)
- `GET /api/jobs/{id}` - Get job by ID (TODO)
- `POST /api/jobs` - Create job (TODO)
- `PUT /api/jobs/{id}` - Update job (TODO)
- `DELETE /api/jobs/{id}` - Delete job (TODO)

## Configuration
- Uses Azure App Configuration for centralized config
- Connection strings stored in Azure Key Vault
- Service Bus connection uses Managed Identity

## Running Locally
```bash
cd services/job-api
dotnet restore
dotnet run
```

Access at: https://localhost:5001

## Dependencies
- .NET 9.0
- Azure App Configuration (TODO)
- Azure Key Vault (TODO)
- Azure Service Bus SDK (TODO)
- SQL Server / Azure SQL (TODO)
