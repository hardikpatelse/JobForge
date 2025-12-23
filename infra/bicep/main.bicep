// Main Bicep template for JobForge infrastructure
// Orchestrates deployment of all Azure resources

targetScope = 'resourceGroup'

@description('Environment name (dev, staging, prod)')
param environment string = 'dev'

@description('Azure region for resources')
param location string = resourceGroup().location

@description('Common tags for all resources')
param tags object = {
  project: 'JobForge'
  managedBy: 'Bicep'
}

// TODO: Import and orchestrate resource modules
// module serviceBus './service-bus.bicep' = {
//   name: 'serviceBusDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

// module sql './sql.bicep' = {
//   name: 'sqlDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

// module apim './apim.bicep' = {
//   name: 'apimDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

// module keyVault './keyvault.bicep' = {
//   name: 'keyVaultDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

// module appConfig './appconfig.bicep' = {
//   name: 'appConfigDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

// module appService './appservice.bicep' = {
//   name: 'appServiceDeploy'
//   params: {
//     environment: environment
//     location: location
//     tags: tags
//   }
// }

output resourceGroupName string = resourceGroup().name
output location string = location
