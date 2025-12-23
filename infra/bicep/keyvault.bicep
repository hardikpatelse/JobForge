// Azure Key Vault for JobForge
// Stores secrets, connection strings, and certificates

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var keyVaultName = 'kv-jobforge-${environment}'

// TODO: Define Key Vault
// resource keyVault 'Microsoft.KeyVault/vaults@2021-11-01-preview' = {
//   name: keyVaultName
//   location: location
//   tags: tags
//   properties: {
//     sku: {
//       family: 'A'
//       name: 'standard'
//     }
//     tenantId: subscription().tenantId
//     enableRbacAuthorization: true // Use RBAC instead of access policies
//     enableSoftDelete: true
//     softDeleteRetentionInDays: 90
//     enablePurgeProtection: true
//     networkAcls: {
//       defaultAction: 'Deny'
//       bypass: 'AzureServices'
//     }
//   }
// }

// TODO: Grant access to service Managed Identities
// Example: Service Bus connection strings, SQL connection strings, API keys

// TODO: Define secrets (no values here - set via Azure CLI or portal)
// - ServiceBus--ConnectionString (reference only, use Managed Identity)
// - Sql--JobApiConnectionString
// - ExternalApis--LinkedInApiKey

// TODO: Enable diagnostic settings

output keyVaultName string = keyVaultName
// output keyVaultUri string = keyVault.properties.vaultUri
