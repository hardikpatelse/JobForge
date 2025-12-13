# Indexer Worker

## Purpose
- Consume JobNormalized events from Service Bus
- Transform normalized job data into search documents
- Index documents in Azure Cognitive Search for fast querying
- Publish JobIndexed events for tracking

## Events Consumed
- **JobNormalized**: Standardized job data ready for indexing
  - Subscription: `indexer-sub` on topic `job-events`
  - Schema: See [docs/contracts/JobNormalized.json](../../docs/contracts/JobNormalized.json)

## Events Published
- **JobIndexed**: Confirmation that job was successfully indexed
  - Topic: `job-events` (optional, for monitoring/analytics)
  - Schema: See [docs/contracts/JobIndexed.json](../../docs/contracts/JobIndexed.json)

## Indexing Logic
- Transform JobNormalized event to search document format
- Map fields to search index schema
- Handle batch indexing for performance (up to 100 documents per batch)
- Update existing documents if job already indexed (based on jobId)
- Extract searchable fields: title, company, description, location, skills

## Configuration
- Uses Azure App Configuration for centralized config
- Service Bus connection uses Managed Identity (no connection strings)
- Azure Cognitive Search connection uses Managed Identity
- Search index name: `jobs-index`

## Retry & Error Handling
- Implements idempotent indexing (same job can be indexed multiple times)
- Maximum delivery count: 10 (configured on subscription)
- Failed messages after max retries sent to dead-letter queue (DLQ)
- Correlation ID propagated for distributed tracing
- Transient Azure Search errors handled with exponential backoff

## Running Locally
```bash
cd workers/indexer-worker
dotnet restore
dotnet run
```

## Dependencies
- .NET 9.0
- Azure Service Bus SDK (TODO)
- Azure Cognitive Search SDK (TODO)
- Azure App Configuration (TODO)
- Azure Key Vault (TODO)
