# SmartFoods Architecture Plan

Version: 1.0
Project Type: Solo Full-Stack Web Application
Primary Framework: ASP.NET Core Blazor Web App (.NET 9)
Architecture Style: Hybrid Clean Architecture + Vertical Slice Architecture
Timeline Target: 2 Weeks MVP
Development Style: AI-Agent Friendly
Deployment Target: Render

---

# 1. Project Vision

SmartFoods is a pantry management and recipe recommendation platform focused on reducing food waste.

The application helps users:

* Track pantry items and expiration dates
* Receive alerts before food expires
* Discover recipes using available ingredients
* Save favorite recipes
* Reduce unnecessary grocery spending

The system is designed as:

* Startup-ready architecture
* MVP-focused implementation
* Easily extendable for future mobile applications
* Easy for AI agents and future developers to onboard into mid-development

---

# 2. Core Architectural Principles

## Primary Goals

The architecture must prioritize:

1. Simplicity over overengineering
2. Clear separation of concerns
3. Fast feature development
4. Maintainability
5. Scalability for future expansion
6. AI-agent readability
7. Predictable folder structure
8. Consistent naming conventions

---

# 3. Finalized Technology Stack

## Runtime & SDK

| Technology          | Version                   |
| ------------------- | ------------------------- |
| .NET SDK            | .NET 9                    |
| ASP.NET Core        | 9                         |
| Blazor Web App      | .NET 9 Interactive Server |
| C# Language Version | Latest Stable             |

---

## Frontend

| Technology        | Version                              |
| ----------------- | ------------------------------------ |
| Blazor Components | .NET 9                               |
| Tailwind CSS      | v4                                   |
| MudBlazor         | Latest Stable Compatible with .NET 9 |
| Hero Icons        | Latest                               |

---

## Backend

| Technology            | Version       |
| --------------------- | ------------- |
| ASP.NET Core Identity | .NET 9        |
| Entity Framework Core | 9             |
| Hangfire              | Latest Stable |
| FluentValidation      | Latest Stable |
| MediatR               | Latest Stable |

---

## Database

| Technology       | Version                     |
| ---------------- | --------------------------- |
| PostgreSQL       | Supabase Managed PostgreSQL |
| EF Core Provider | Npgsql EF Core Provider     |

Reasoning:

* Free hosted PostgreSQL
* Production-grade relational database
* Excellent EF Core support
* Easy cloud deployment
* Good portfolio value

---

## External Services

| Service         | Purpose                |
| --------------- | ---------------------- |
| SendGrid        | Email notifications    |
| Spoonacular API | Recipe recommendations |

---

## Testing

| Tool                   | Purpose             |
| ---------------------- | ------------------- |
| xUnit                  | Unit testing        |
| FluentAssertions       | Assertions          |
| ASP.NET Core Test Host | Integration testing |

---

## Logging

| Tool                     | Purpose         |
| ------------------------ | --------------- |
| Built-in ASP.NET Logging | Initial logging |

Advanced logging intentionally postponed.

---

# 4. High-Level System Architecture

## Architecture Style

The project uses:

* Hybrid Clean Architecture
* Vertical Slice Features
* Layered Separation

This balances:

* Enterprise-level organization
* Rapid MVP development
* Lower complexity for solo development

---

# 5. Solution Structure

```text
SmartFoods/
│
├── src/
│   │
│   ├── SmartFoods.Web/
│   │
│   ├── SmartFoods.Application/
│   │
│   ├── SmartFoods.Domain/
│   │
│   ├── SmartFoods.Infrastructure/
│
├── tests/
│   │
│   ├── SmartFoods.UnitTests/
│   │
│   ├── SmartFoods.IntegrationTests/
│
├── docs/
│   │
│   ├── architectural-plan.md
│   │
│   ├── implementation-tracker.md
│   │
│   ├── api-contracts.md
│   │
│   ├── database-design.md
│
├── README.md
│
└── SmartFoods.sln
```

---

# 6. Layer Responsibilities

## 6.1 SmartFoods.Web

Purpose:

Presentation layer.

Responsibilities:

* Blazor pages
* Components
* Authentication UI
* Form validation display
* API endpoint definitions
* Dependency injection setup
* Tailwind styling
* MudBlazor integration

Must NOT contain:

* Database logic
* Business rules
* Direct SQL
* External service logic

---

## 6.2 SmartFoods.Application

Purpose:

Business logic layer.

Responsibilities:

* Feature handlers
* Validation
* Use cases
* DTOs
* Interfaces
* Service contracts
* Feature orchestration

Contains:

* Commands
* Queries
* Validators
* Result models
* Interfaces

---

## 6.3 SmartFoods.Domain

Purpose:

Pure business domain.

Responsibilities:

* Entities
* Enums
* Domain rules
* Constants
* Domain events (optional future)

Must remain:

* Framework-independent
* Database-independent
* UI-independent

---

## 6.4 SmartFoods.Infrastructure

Purpose:

External implementation layer.

Responsibilities:

* EF Core
* PostgreSQL access
* SendGrid implementation
* Spoonacular integration
* Identity implementation
* Repository implementations
* Hangfire jobs

---

# 7. Vertical Slice Feature Organization

Inside Application layer:

```text
Features/
│
├── Auth/
│   ├── Login/
│   ├── Register/
│   └── Logout/
│
├── Pantry/
│   ├── AddItem/
│   ├── UpdateItem/
│   ├── DeleteItem/
│   ├── GetDashboard/
│   └── GetExpiringItems/
│
├── Recipes/
│   ├── SearchRecipes/
│   ├── SaveRecipe/
│   └── GetSavedRecipes/
│
├── Notifications/
│   └── SendExpirationAlerts/
```

Each feature folder contains:

```text
FeatureName/
│
├── Command.cs
├── Handler.cs
├── Validator.cs
├── Response.cs
└── Mapping.cs
```

This structure is intentionally AI-agent friendly.

An AI model can enter any feature folder and immediately understand:

* inputs
* outputs
* validation
* business logic
* dependencies

---

# 8. Database Architecture

## Database Provider

Supabase PostgreSQL

Connection management handled through:

* Environment variables
* ASP.NET configuration system

---

# 9. Core Database Tables

## Users

Managed primarily by ASP.NET Core Identity.

Additional custom fields:

| Field        | Type      |
| ------------ | --------- |
| Id           | GUID      |
| FirstName    | string    |
| LastName     | string    |
| CreatedAtUtc | timestamp |

---

## PantryItems

| Field          | Type      |
| -------------- | --------- |
| Id             | GUID      |
| UserId         | GUID      |
| Name           | string    |
| Quantity       | decimal   |
| Unit           | string    |
| ExpirationDate | timestamp |
| CreatedAtUtc   | timestamp |
| UpdatedAtUtc   | timestamp |

---

## SavedRecipes

| Field      | Type      |
| ---------- | --------- |
| Id         | GUID      |
| UserId     | GUID      |
| RecipeId   | string    |
| Title      | string    |
| ImageUrl   | string    |
| SourceUrl  | string    |
| SavedAtUtc | timestamp |

---

# 10. Authentication Architecture

## Authentication Method

ASP.NET Core Identity

Authentication flow:

```text
User Login
    ↓
Identity validates credentials
    ↓
Cookie Authentication
    ↓
Secure session established
```

---

## Security Decisions

| Feature            | Decision                  |
| ------------------ | ------------------------- |
| Password Hashing   | ASP.NET Identity Built-In |
| Authentication     | Cookie Auth               |
| Session Management | ASP.NET Identity          |
| HTTPS              | Required                  |
| CSRF Protection    | Enabled                   |
| Secrets Storage    | Environment Variables     |

JWT intentionally postponed.

Reason:

Cookie auth is simpler and safer for this architecture.

---

# 11. Recipe API Integration Strategy

## External API

Spoonacular API

---

## Integration Flow

```text
User Pantry Items
    ↓
Ingredient Aggregation
    ↓
Spoonacular Query
    ↓
Recipe Results
    ↓
Mapped DTO Response
```

---

## API Abstraction

Application Layer:

```text
IRecipeService
```

Infrastructure Layer:

```text
SpoonacularRecipeService
```

This allows future provider swapping.

---

# 12. Email Notification Architecture

## Notification Trigger

Hangfire recurring background jobs.

---

## Daily Flow

```text
Hangfire Scheduled Job
    ↓
Query expiring pantry items
    ↓
Group by user
    ↓
Generate email content
    ↓
SendGrid dispatch
```

---

## Notification Window

Food expiring within:

```text
48 hours
```

---

## Abstraction

Application Layer:

```text
IEmailService
```

Infrastructure Layer:

```text
SendGridEmailService
```

---

# 13. UI Architecture

## UI Philosophy

The UI should be:

* Fast
* Minimal
* Mobile-first
* Clean
* Dashboard-focused

---

# 14. Styling Strategy

## Tailwind Responsibilities

Used for:

* Layouts
* Responsive design
* Spacing
* Typography
* Color system

---

## MudBlazor Responsibilities

Used for:

* Dialogs
* Snackbars
* Data tables
* Form controls
* Date pickers
* Loaders

Avoid excessive MudBlazor styling overrides.

---

# 15. State Management Strategy

Keep state management simple.

Use:

* Component state
* Scoped services
* Cascading parameters when necessary

Avoid:

* Redux patterns
* Complex global state systems

---

# 16. Environment Strategy

## Environments

```text
Development
Testing
Production
```

---

## Secrets Management

Never hardcode:

* API keys
* Database strings
* SendGrid keys
* Spoonacular keys

Use:

```text
appsettings.json
appsettings.Development.json
Environment Variables
```

---

# 17. API Strategy

Although Blazor can directly call services internally, this project will still expose minimal API endpoints.

Reason:

This prepares the project for:

* Future mobile app
* Future MAUI client
* Easier external integrations
* Cleaner architecture boundaries

---

## API Pattern

```text
/api/pantry
/api/recipes
/api/auth
```

---

# 18. Testing Architecture

## Unit Tests

Test:

* Business logic
* Validators
* Feature handlers
* Services

Do NOT unit test:

* MudBlazor components
* EF Core internals

---

## Integration Tests

Test:

* API endpoints
* Database interaction
* Authentication flows

---

# 19. Logging Strategy

Initial logging strategy:

```text
ILogger<T>
```

Log:

* API failures
* Background job failures
* External API failures
* Authentication issues

Avoid premature advanced observability.

---

# 20. Naming Conventions

## C# Naming

| Item           | Convention     |
| -------------- | -------------- |
| Classes        | PascalCase     |
| Methods        | PascalCase     |
| Interfaces     | Prefix I       |
| Private Fields | _camelCase     |
| DTOs           | Suffix Dto     |
| Commands       | Suffix Command |
| Queries        | Suffix Query   |
| Handlers       | Suffix Handler |

---

## Folder Naming

Use:

```text
FeatureName/
```

Avoid:

```text
feature-name/
feature_name/
```

---

# 21. Dependency Rules

## Allowed Dependencies

```text
Web → Application
Web → Infrastructure

Application → Domain

Infrastructure → Application
Infrastructure → Domain
```

---

## Forbidden Dependencies

```text
Domain → Anything

Application → Infrastructure
```

These rules are extremely important.

---

# 22. Development Workflow

## Feature Development Flow

Every feature follows:

```text
1. Domain Model
2. DTO/Contracts
3. Validation
4. Handler Logic
5. Infrastructure Integration
6. UI Components
7. Tests
```

---

# 23. Recommended Git Workflow

## Branch Naming

```text
feature/pantry-dashboard
feature/recipe-search
bugfix/login-redirect
```

---

## Commit Style

```text
feat: add pantry item creation
fix: resolve expiration sorting issue
refactor: simplify recipe service
```

---

# 24. MVP Feature Priority Order

## Phase 1 — Foundation

* Create solution
* Configure projects
* Configure PostgreSQL
* Configure Identity
* Configure Tailwind
* Configure MudBlazor
* Configure EF Core
* Configure migrations

---

## Phase 2 — Authentication

* Register
* Login
* Logout
* Protected routes
* Session handling

---

## Phase 3 — Pantry System

* Add pantry item
* Edit pantry item
* Delete pantry item
* Dashboard view
* Expiration color coding

---

## Phase 4 — Recipe System

* Spoonacular integration
* Recipe search
* Ingredient matching
* Save favorite recipes

---

## Phase 5 — Notifications

* Hangfire setup
* Expiration scheduler
* SendGrid integration
* Email templates

---

## Phase 6 — Testing & Polish

* Unit tests
* Integration tests
* Error handling
* Mobile responsiveness
* UI cleanup
* Final deployment fixes

---

# 25. Future Expansion Readiness

Architecture must support future:

* Mobile apps
* Push notifications
* Shared family pantry
* Barcode scanning
* AI meal planning
* OCR receipt scanning
* Shopping lists
* Budget tracking

WITHOUT major rewrites.

---

# 26. Deliberately Excluded Complexity

The following are intentionally excluded:

* Microservices
* Kubernetes
* Docker
* Event sourcing
* CQRS complexity overload
* Distributed caching
* Redis
* Message brokers
* GraphQL
* Advanced observability
* Real-time synchronization

Reason:

The goal is:

```text
Fast execution + clean architecture + maintainability
```

NOT enterprise overengineering.

---

# 27. AI-Agent Development Rules

Future AI agents working on this project MUST:

1. Respect dependency rules
2. Never place business logic inside UI components
3. Keep feature folders isolated
4. Avoid creating shared utility chaos
5. Prefer feature-level organization
6. Never bypass validation
7. Keep services interface-driven
8. Avoid premature abstractions
9. Keep methods focused and small
10. Prefer readability over cleverness

---

# 28. Definition of Done

A feature is considered complete only if:

* Business logic implemented
* Validation implemented
* UI completed
* Error handling added
* Database migration updated
* Tests written
* Mobile responsiveness verified
* Naming conventions respected

---

# 29. Recommended Development Order (2 Week Timeline)

## Week 1

Focus:

* Foundation
* Authentication
* Pantry system

Goal:

Fully functional pantry dashboard.

---

## Week 2

Focus:

* Recipe integration
* Email notifications
* Testing
* Deployment
* UI polish

Goal:

Production-ready MVP.

---

# 30. Final Architectural Summary

SmartFoods uses:

* Blazor Web App (.NET 9)
* Interactive Server rendering
* PostgreSQL (Supabase)
* ASP.NET Identity
* Tailwind CSS
* MudBlazor
* Hangfire
* SendGrid
* Spoonacular
* Clean Architecture principles
* Vertical Slice feature organization

The architecture is optimized for:

* Solo development
* Fast AI-assisted implementation
* Maintainability
* Future expansion
* Simplicity without sacrificing professionalism
