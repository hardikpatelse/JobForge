# Ingestion Worker

Purpose:
- Ingest job postings from external sources.
- Publish JobFetched events to Service Bus Topic.

Notes:
- Use Managed Identity for Service Bus.
- Implement retry policies and DLQ handling.
