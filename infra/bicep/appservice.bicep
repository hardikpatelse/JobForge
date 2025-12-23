// Azure App Service plans and web apps for JobForge services
// Hosts API services and worker services

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var appServicePlanName = 'asp-jobforge-${environment}'

// TODO: Define App Service Plan
// resource appServicePlan 'Microsoft.Web/serverfarms@2021-03-01' = {
//   name: appServicePlanName
//   location: location
//   tags: tags
//   sku: {
//     name: environment == 'prod' ? 'P1v3' : 'B1'
//     tier: environment == 'prod' ? 'PremiumV3' : 'Basic'
//   }
//   kind: 'linux'
//   properties: {
//     reserved: true // Linux
//   }
// }

// TODO: Define App Services for APIs
// resource jobApi 'Microsoft.Web/sites@2021-03-01' = {
//   name: 'app-jobforge-job-api-${environment}'
//   location: location
//   tags: tags
//   kind: 'app,linux'
//   identity: {
//     type: 'SystemAssigned'
//   }
//   properties: {
//     serverFarmId: appServicePlan.id
//     httpsOnly: true
//     siteConfig: {
//       linuxFxVersion: 'DOTNETCORE|9.0'
//       alwaysOn: true
//       minTlsVersion: '1.2'
//       ftpsState: 'Disabled'
//       healthCheckPath: '/health'
//     }
//   }
// }

// TODO: Define App Services for Workers
// resource ingestionWorker 'Microsoft.Web/sites@2021-03-01' = {
//   name: 'app-jobforge-ingestion-worker-${environment}'
//   location: location
//   tags: tags
//   kind: 'app,linux'
//   identity: {
//     type: 'SystemAssigned'
//   }
//   properties: {
//     serverFarmId: appServicePlan.id
//     httpsOnly: true
//     siteConfig: {
//       linuxFxVersion: 'DOTNETCORE|9.0'
//       alwaysOn: true
//     }
//   }
// }

// TODO: Configure app settings with App Configuration and Key Vault references
// TODO: Enable Application Insights
// TODO: Configure VNet integration (if needed)

output appServicePlanName string = appServicePlanName
// output jobApiName string = jobApi.name
// output ingestionWorkerName string = ingestionWorker.name
