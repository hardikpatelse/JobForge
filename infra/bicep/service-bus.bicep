// Azure Service Bus namespace and topics for JobForge
// Handles asynchronous messaging between services

@description('Environment name (dev, staging, prod)')
param environment string

@description('Azure region')
param location string

@description('Resource tags')
param tags object

var serviceBusNamespaceName = 'sbns-jobforge-${environment}'

// TODO: Define Service Bus Namespace
// resource serviceBusNamespace 'Microsoft.ServiceBus/namespaces@2021-11-01' = {
//   name: serviceBusNamespaceName
//   location: location
//   tags: tags
//   sku: {
//     name: 'Standard'
//     tier: 'Standard'
//   }
//   properties: {
//     disableLocalAuth: true // Enforce Managed Identity only
//   }
// }

// TODO: Define Topics and Subscriptions
// resource jobEventsTopic 'Microsoft.ServiceBus/namespaces/topics@2021-11-01' = {
//   parent: serviceBusNamespace
//   name: 'job-events'
//   properties: {
//     enablePartitioning: true
//     defaultMessageTimeToLive: 'P14D' // 14 days
//   }
// }

// resource normalizerSubscription 'Microsoft.ServiceBus/namespaces/topics/subscriptions@2021-11-01' = {
//   parent: jobEventsTopic
//   name: 'normalizer-sub'
//   properties: {
//     maxDeliveryCount: 10
//     deadLetteringOnMessageExpiration: true
//     enableBatchedOperations: true
//   }
// }

// TODO: Add authorization rules for Managed Identity access
// TODO: Enable diagnostic settings for monitoring

output namespaceName string = serviceBusNamespaceName
// output topicName string = jobEventsTopic.name
