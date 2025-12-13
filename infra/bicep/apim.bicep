// Azure API Management for JobForge
// Single entry point for all API services

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var apimName = 'apim-jobforge-${environment}'

// TODO: Define APIM instance
// resource apim 'Microsoft.ApiManagement/service@2021-08-01' = {
//   name: apimName
//   location: location
//   tags: tags
//   sku: {
//     name: environment == 'prod' ? 'Standard' : 'Developer'
//     capacity: 1
//   }
//   properties: {
//     publisherEmail: 'admin@jobforge.io'
//     publisherName: 'JobForge'
//   }
//   identity: {
//     type: 'SystemAssigned'
//   }
// }

// TODO: Define APIs for each service
// resource jobApi 'Microsoft.ApiManagement/service/apis@2021-08-01' = {
//   parent: apim
//   name: 'job-api'
//   properties: {
//     displayName: 'Job API'
//     path: 'jobs'
//     protocols: ['https']
//     subscriptionRequired: true
//   }
// }

// TODO: Configure policies
// - Rate limiting
// - JWT validation
// - CORS
// - Response caching

// TODO: Configure backends pointing to App Services
// TODO: Enable diagnostic settings and Application Insights

output apimName string = apimName
// output apimGatewayUrl string = apim.properties.gatewayUrl
