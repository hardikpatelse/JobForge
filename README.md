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
├── frontend/jobforge-ui/
├── services/
│   ├── job-api/
│   ├── search-api/
│   └── user-api/
├── workers/
│   ├── ingestion-worker/
│   ├── normalizer-worker/
│   └── indexer-worker/
├── infra/
│   ├── bicep/
│   └── helm/
├── pipelines/
│   ├── ci.yml
│   └── cd.yml
└── docs/
    ├── architecture/
    ├── contracts/
    └── ADR/
```

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
