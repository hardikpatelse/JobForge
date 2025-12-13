// Azure App Configuration for JobForge
// Centralized configuration management with Key Vault references

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var appConfigName = 'appconfig-jobforge-${environment}'

// TODO: Define App Configuration
// resource appConfig 'Microsoft.AppConfiguration/configurationStores@2021-10-01-preview' = {
//   name: appConfigName
//   location: location
//   tags: tags
//   sku: {
//     name: 'Standard'
//   }
//   properties: {
//     disableLocalAuth: true // Enforce Managed Identity only
//   }
//   identity: {
//     type: 'SystemAssigned'
//   }
// }

// TODO: Define configuration key-values
// - Feature flags
// - Service endpoints (APIM URLs)
// - Key Vault references for secrets

// TODO: Grant read access to service Managed Identities
// TODO: Enable diagnostic settings

output appConfigName string = appConfigName
// output appConfigEndpoint string = appConfig.properties.endpoint
