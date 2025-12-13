# Normalizer Worker

Purpose:
- Consume JobFetched events; normalize data.
- Publish JobNormalized events.

Notes:
- Idempotency; correlation IDs; retry policies; DLQ handling.
