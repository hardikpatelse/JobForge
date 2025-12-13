# Infrastructure

Deploy Azure resources via Bicep. Enforce:
- Managed Identity for access to Service Bus, SQL, Key Vault, App Config
- No secrets in code; use Key Vault + App Configuration references
- APIM as gateway for all services

Run (placeholder):
- az deployment group create -f ./bicep/main.bicep -g <resourceGroup> -p ...
