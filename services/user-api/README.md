# User API

## Responsibilities
- Manage user profiles and authentication
- Handle user preferences and saved searches
- Manage user job applications and bookmarks
- Provide user-specific data and settings

## Boundaries
- Own database (UsersDatabase)
- No cross-service DB queries
- Exposed only via Azure API Management (APIM)

## Endpoints
- `GET /health` - Health check endpoint
- `GET /api/users/profile` - Get user profile (placeholder)
- `PUT /api/users/profile` - Update user profile (TODO)
- `GET /api/users/saved-searches` - Get saved searches (TODO)
- `POST /api/users/saved-searches` - Save a search (TODO)
- `GET /api/users/applications` - Get job applications (TODO)

## Configuration
- Uses Azure App Configuration for centralized config
- Connection strings stored in Azure Key Vault
- Authentication via Azure AD / JWT tokens

## Running Locally
```bash
cd services/user-api
dotnet restore
dotnet run
```

Access at: https://localhost:5003

## Dependencies
- .NET 9.0
- Azure App Configuration (TODO)
- Azure Key Vault (TODO)
- Azure AD for authentication (TODO)
- SQL Server / Azure SQL (TODO)
