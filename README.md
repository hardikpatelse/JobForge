### 🚀 JobForge

**JobForge** is a production-grade, event-driven job aggregation platform designed to demonstrate modern **microservices architecture** using **.NET 9, Angular 20, and Azure PaaS services**.

The system aggregates job postings from multiple external sources, processes them asynchronously using **Azure Service Bus**, and exposes clean, scalable APIs consumed by an Angular SPA.

This repository is intentionally built as a **learning-first, real-world architecture**, focusing on:

* Proper service boundaries
* Asynchronous messaging
* Cloud-native deployment patterns
* Progressive adoption of containers and Kubernetes (AKS)

> Repo sidebar: Event-driven job aggregation platform using .NET 9, Angular 20, Azure Service Bus, and cloud-native microservices architecture.

## 🧱 Architecture Overview

JobForge follows a microservices-based, event-driven architecture:

- Frontend: Angular 20 + Tailwind
- Backend: .NET 9 microservices
- Messaging: Azure Service Bus (Topics & Subscriptions)
- API Gateway: Azure API Management
- Data: Azure SQL / Cosmos DB
- Search: Azure Cognitive Search
- Security: Managed Identity, Azure Key Vault
- CI/CD: Azure DevOps / GitHub Actions
- Hosting: Azure App Services → Docker → AKS (progressive)

## 🎯 Learning Objectives

- Understand real microservices boundaries and trade-offs
- Implement asynchronous workflows using Azure Service Bus
- Apply Azure PaaS best practices (Managed Identity, Key Vault, APIM)
- Learn containerization with Docker and image optimization
- Progressively adopt Kubernetes (AKS) without over-engineering
- Build CI/CD pipelines aligned with cloud-native systems

## ❗ What This Project Is (and Is Not)

✔ A realistic, production-style system  
✔ Focused on architecture and platform learning  
✔ Designed for scalability and resilience  

✘ Not a CRUD-only demo  
✘ Not a “hello world” microservices example  
✘ Not optimized for fastest development time  

## Repository Structure

```text
jobforge/
├── .editorconfig              # Editor configuration for consistent formatting
├── .gitignore                 # Git ignore rules for .NET, Node, and OS files
├── CODEOWNERS                 # Code ownership for PR reviews
├── CONTRIBUTING.md            # Contribution guidelines and branching strategy
├── LICENSE                    # MIT License
├── README.md                  # This file
├── SECURITY.md                # Security guidelines and policies
├── TASKS.md                   # Task plan and execution roadmap
├── frontend/
│   └── jobforge-ui/           # Angular 20 standalone app with Tailwind
├── services/
│   ├── job-api/               # .NET 9 API for job management
│   ├── search-api/            # .NET 9 API for job search (Azure Cognitive Search)
│   └── user-api/              # .NET 9 API for user profiles and preferences
├── workers/
│   ├── ingestion-worker/      # .NET 9 worker for fetching jobs from external sources
│   ├── normalizer-worker/     # .NET 9 worker for normalizing raw job data
│   └── indexer-worker/        # .NET 9 worker for indexing jobs in search
├── infra/
│   ├── bicep/                 # Bicep templates for Azure infrastructure
│   └── helm/                  # Helm charts for AKS (Phase 8)
├── pipelines/
│   ├── ci.yml                 # CI pipeline stub (build, test, lint)
│   └── cd.yml                 # CD pipeline stub (deploy to Azure)
└── docs/
    ├── architecture/          # C4 model diagrams (system, container)
    ├── contracts/             # Event JSON schemas (JobFetched, JobNormalized, JobIndexed)
    └── ADR/                   # Architecture Decision Records
```

## Getting Started

### Prerequisites
- .NET 9 SDK
- Node.js 20.x or higher
- Azure CLI (for infrastructure deployment)
- Docker (for Phase 7+)

### Quick Start

#### 1. Clone the Repository
```bash
git clone https://github.com/hardikpatelse/JobForge.git
cd JobForge
```

#### 2. Build Backend Services
```bash
# Build all .NET projects
dotnet build services/job-api/JobForge.Job.API.csproj
dotnet build services/search-api/JobForge.Search.API.csproj
dotnet build services/user-api/JobForge.User.API.csproj

# Build all workers
dotnet build workers/ingestion-worker/JobForge.Ingestion.Worker.csproj
dotnet build workers/normalizer-worker/JobForge.Normalizer.Worker.csproj
dotnet build workers/indexer-worker/JobForge.Indexer.Worker.csproj
```

#### 3. Run a Service Locally
```bash
cd services/job-api
dotnet run
# Navigate to http://localhost:5010/health
```

#### 4. Frontend Setup
```bash
cd frontend/jobforge-ui
npm install
npm start
# Navigate to http://localhost:4200
```

#### 5. Deploy Infrastructure (Phase 2)
```bash
cd infra/bicep
az deployment group create \
  --resource-group jobforge-rg \
  --template-file main.bicep \
  --parameters environment=dev
```

### Project Status

This is the **initial scaffolding** phase (Phase 0-1). The repository includes:

✅ Complete directory structure  
✅ Minimal, compilable .NET 9 services and workers  
✅ Angular 20 standalone app structure  
✅ Bicep infrastructure templates (placeholders)  
✅ Event contract JSON schemas  
✅ CI/CD pipeline stubs  
✅ Governance files (.editorconfig, .gitignore, CODEOWNERS)  

See [TASKS.md](TASKS.md) for the full roadmap.

## Hard Advice (Don’t Skip This)

- Do not call this a “sample” or “toy” project
- Do not dump all services in one folder
- Do not introduce Kubernetes in week one
- Do not overpromise in README—deliver incrementally

## Governance

- Branching: main (production), develop (integration)
- Services exposed only via APIM
- No shared DTO projects; use event contracts
- No cross-service DB queries
- No secrets in code or pipelines; use Managed Identity + Key Vault

## Next Steps

- Phase 1: finalize service boundaries and event contracts in docs/contracts
- Phase 2: implement infra via Bicep, deploy with one command
- Phase 3+: build APIs, workers, and frontend incrementally
