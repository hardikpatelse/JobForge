// Environment configuration for production
// IMPORTANT: All API URLs must point to APIM gateway, not direct service URLs

export const environment = {
  production: true,
  apiGatewayUrl: 'https://apim-jobforge-prod.azure-api.net',
  endpoints: {
    jobs: '/jobs',
    search: '/search',
    users: '/users'
  },
  appInsights: {
    instrumentationKey: 'PLACEHOLDER - Use App Configuration'
  }
};
