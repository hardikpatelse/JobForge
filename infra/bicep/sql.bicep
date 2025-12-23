// Azure SQL Database for JobForge services
// Each service should have its own database

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var sqlServerName = 'sql-jobforge-${environment}'

// TODO: Define SQL Server
// resource sqlServer 'Microsoft.Sql/servers@2021-11-01' = {
//   name: sqlServerName
//   location: location
//   tags: tags
//   properties: {
//     administratorLogin: '' // Use AAD authentication only
//     minimalTlsVersion: '1.2'
//     publicNetworkAccess: 'Disabled' // VNet integration required
//   }
//   identity: {
//     type: 'SystemAssigned'
//   }
// }

// TODO: Define databases for each service
// resource jobApiDatabase 'Microsoft.Sql/servers/databases@2021-11-01' = {
//   parent: sqlServer
//   name: 'jobforge-jobs-${environment}'
//   location: location
//   tags: tags
//   sku: {
//     name: 'S0'
//     tier: 'Standard'
//   }
// }

// resource userApiDatabase 'Microsoft.Sql/servers/databases@2021-11-01' = {
//   parent: sqlServer
//   name: 'jobforge-users-${environment}'
//   location: location
//   tags: tags
//   sku: {
//     name: 'S0'
//     tier: 'Standard'
//   }
// }

// TODO: Configure firewall rules (VNet integration)
// TODO: Enable auditing and threat detection
// TODO: Configure backup policies

output sqlServerName string = sqlServerName
// output jobApiDatabaseName string = jobApiDatabase.name
// output userApiDatabaseName string = userApiDatabase.name
