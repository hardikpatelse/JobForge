# JobForge UI (Angular 20)

## Overview
JobForge UI is a modern, production-grade Angular 20 application using standalone APIs and Tailwind CSS for styling. The application provides a user-friendly interface for searching and browsing job postings.

## Architecture Principles
- **Standalone Components**: All components use Angular standalone APIs (no NgModule)
- **APIM-Only Access**: All API calls must go through Azure API Management gateway
- **Environment-Based Config**: No hardcoded URLs; configuration via environment files
- **Lazy Loading**: Feature modules loaded on-demand for optimal performance

## Key Features (Planned)
- Job search with filters (location, salary, type, etc.)
- Job details and application tracking
- User profile and saved searches
- Responsive design with Tailwind CSS
- Progressive Web App (PWA) capabilities

## Configuration
All API endpoints are configured in `src/environments/`:
- `environment.development.ts` - Development settings
- `environment.ts` - Production settings

**IMPORTANT**: Never hardcode API URLs. All requests must go through the APIM gateway defined in `apiGatewayUrl`.

## Running Locally

### Prerequisites
- Node.js 20.x or higher
- npm 10.x or higher

### Installation
```bash
cd frontend/jobforge-ui
npm install
```

### Development Server
```bash
npm start
# or
ng serve
```

Navigate to `http://localhost:4200/`. The application will automatically reload on file changes.

### Build
```bash
npm run build
# Output: dist/jobforge-ui/
```

### Testing
```bash
npm test
```

### Linting
```bash
npm run lint
```

## Project Structure
```
src/
├── app/
│   ├── app.component.ts      # Root component
│   ├── app.config.ts         # Application configuration
│   ├── app.routes.ts         # Route definitions
│   └── features/             # TODO: Feature modules (jobs, search, profile)
├── assets/                   # Static assets
├── environments/             # Environment configurations
├── index.html               # HTML entry point
├── main.ts                  # Bootstrap file
└── styles.scss              # Global styles
```

## Development Guidelines
- Use standalone components, directives, and pipes
- Follow Angular style guide and conventions
- Implement lazy loading for feature modules
- Use signals for state management (Angular 20+)
- Configure Tailwind CSS for styling (see TODO in styles.scss)
- Implement proper error handling and loading states
- Add correlation IDs to all API requests for distributed tracing

## Security
- API calls authenticated via JWT tokens (TODO)
- HTTPS only in production
- Content Security Policy (CSP) headers
- No sensitive data in client-side code

## Dependencies
- Angular 20.x (standalone APIs)
- RxJS for reactive programming
- Tailwind CSS for styling (TODO: Configure)
- Angular Router for navigation

## Future Enhancements
- PWA support with service workers
- Server-side rendering (SSR) with Angular Universal
- Application Insights integration
- End-to-end tests with Cypress or Playwright
