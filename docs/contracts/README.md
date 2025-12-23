# Event Contracts

This directory contains JSON Schema definitions for all events published in the JobForge system.

## Events

### JobFetched
Published by: `ingestion-worker`  
Consumed by: `normalizer-worker`  
Schema: [JobFetched.json](./JobFetched.json)

Triggered when a job posting is successfully fetched from an external source (e.g., LinkedIn, Indeed, Glassdoor).

### JobNormalized
Published by: `normalizer-worker`  
Consumed by: `indexer-worker`, `job-api`  
Schema: [JobNormalized.json](./JobNormalized.json)

Triggered when a raw job posting is transformed into the standardized JobForge format.

### JobIndexed
Published by: `indexer-worker`  
Consumed by: `search-api`  
Schema: [JobIndexed.json](./JobIndexed.json)

Triggered when a normalized job is successfully indexed in Azure Cognitive Search.

## Schema Validation

All events must conform to their respective JSON schemas. Services should validate incoming events against these schemas before processing.

## Versioning

- Event schemas use semantic versioning
- Breaking changes require a new major version
- All schema changes must be reviewed by the architecture team (see CODEOWNERS)

## Usage

Services should use these schemas to:
1. Validate event payloads before publishing
2. Generate strongly-typed models in their respective languages (.NET, TypeScript)
3. Document API contracts and service boundaries

## Best Practices

- Always include `eventId` for deduplication
- Always include `correlationId` for distributed tracing
- Use ISO 8601 format for timestamps
- Keep event payloads small; reference large data by ID
- Design for idempotency
