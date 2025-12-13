# Normalizer Worker

## Purpose
- Consume JobFetched events from Service Bus
- Parse and normalize raw job data into standardized format
- Publish JobNormalized events for downstream consumers

## Events Consumed
- **JobFetched**: Raw job data from external sources
  - Subscription: `normalizer-sub` on topic `job-events`
  - Schema: See [docs/contracts/JobFetched.json](../../docs/contracts/JobFetched.json)

## Events Published
- **JobNormalized**: Standardized job data ready for indexing
  - Topic: `job-events`
  - Schema: See [docs/contracts/JobNormalized.json](../../docs/contracts/JobNormalized.json)

## Normalization Logic
- Extract and standardize job title, company, location
- Parse salary information into consistent format
- Normalize employment type (full-time, part-time, contract, internship)
- Clean and format job description
- Extract posting date and convert to ISO 8601

## Configuration
- Uses Azure App Configuration for centralized config
- Service Bus connection uses Managed Identity (no connection strings)
- Processor settings: max concurrent calls, prefetch count

## Retry & Error Handling
- Implements idempotent processing (same message can be processed multiple times)
- Maximum delivery count: 10 (configured on subscription)
- Failed messages after max retries sent to dead-letter queue (DLQ)
- Correlation ID propagated for distributed tracing

## Running Locally
```bash
cd workers/normalizer-worker
dotnet restore
dotnet run
```

## Dependencies
- .NET 9.0
- Azure Service Bus SDK (TODO)
- Azure App Configuration (TODO)
- Azure Key Vault (TODO)
