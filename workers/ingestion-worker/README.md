# Ingestion Worker

## Purpose
- Ingest job postings from external sources (LinkedIn, Indeed, Glassdoor)
- Transform raw job data into standardized format
- Publish JobFetched events to Azure Service Bus topic

## Events Published
- **JobFetched**: Published when a job is successfully fetched from an external source
  - Topic: `job-events`
  - Schema: See [docs/contracts/JobFetched.json](../../docs/contracts/JobFetched.json)

## Events Consumed
- None (this is the entry point for the pipeline)

## Configuration
- Uses Azure App Configuration for centralized config
- External API keys stored in Azure Key Vault
- Service Bus connection uses Managed Identity (no connection strings)

## Retry & Error Handling
- Implements exponential backoff for transient failures
- Maximum retry attempts: 3
- Failed messages sent to dead-letter queue (DLQ)
- Correlation ID propagated for distributed tracing

## Running Locally
```bash
cd workers/ingestion-worker
dotnet restore
dotnet run
```

## Dependencies
- .NET 9.0
- Azure Service Bus SDK (TODO)
- Azure App Configuration (TODO)
- Azure Key Vault (TODO)
- HttpClient for external API calls (TODO)
