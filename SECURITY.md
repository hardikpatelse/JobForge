# Security Guidance

- Use Managed Identity for all Azure resource access.
- Store secrets in Azure Key Vault; reference via App Configuration.
- No secrets or connection strings in source code or pipelines.
- Access services via APIM; do not expose App Services directly.
- Enable HTTPS only; enforce TLS in APIM.
- Workers must implement retry policies and DLQ handling.
- Audit and logs: use Application Insights with correlation IDs.
