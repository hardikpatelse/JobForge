// Environment configuration for development
// IMPORTANT: All API URLs must point to APIM gateway, not direct service URLs

export const environment = {
  production: false,
  apiGatewayUrl: 'https://apim-jobforge-dev.azure-api.net',
  endpoints: {
    jobs: '/jobs',
    search: '/search',
    users: '/users'
  },
  appInsights: {
    instrumentationKey: 'PLACEHOLDER - Use App Configuration'
  }
};
