# Solution with Docker, Selenium, and Razor Pages

This .NET 6 solution is based on a Selenium/Docker course on Udemy.   
It features:
- **ProductAPI**: A RESTful API for product management.
- **EAWebApp**: A Razor Pages web application for interacting with the API.
- **EAAppTest**: A couple of tests that use Selenium Grid.
- **ea_network**: A Docker network connecting all containers.

---

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
- [Development](#development)
- [Docker Support](#docker-support)

---

## Features

- Product CRUD operations via REST API
- Razor Pages frontend for product management
- Entity Framework Core with SQL Server
- Data seeding for development
- Swagger/OpenAPI documentation
- Dockerized for easy deployment

---

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Docker](https://www.docker.com/)

---

## API Endpoints

- `GET /api/products` - List all products
- `GET /api/products/{id}` - Get product by ID
- `POST /api/products` - Create a new product
- `PUT /api/products/{id}` - Update a product
- `DELETE /api/products/{id}` - Delete a product

See Swagger UI at `/swagger` for full API documentation.

---

## Development

- Code style is enforced via `.editorconfig` and [StyleCop.Analyzers](https://www.nuget.org/packages/StyleCop.Analyzers).
- Data is seeded automatically in development via `SeedData.cs`.

---

## Docker Support

Build the solution and run the tests with Docker Compose:
---

docker-compose up --build

---

## Branches

This repository contains two main branches, each with a different approach to Selenium test execution and CI integration:

- **main**  
  The default branch.  
  - Includes GitHub Actions workflows for CI/CD.
  - Selenium tests are configured to run in environments compatible with GitHub Actions (such as local WebDriver or supported cloud services).
  - Recommended for most users, especially when running tests in GitHub Actions or other CI/CD pipelines.

- **using-selenium-nodes**  
  Uses a custom Selenium Grid setup (e.g., via Docker Compose with multiple browser nodes).  
  - Not compatible with GitHub Actions due to the way Selenium Grid is orchestrated.
  - Intended for local or custom Docker-based environments where you want to run tests across multiple browsers/nodes.

**How to choose a branch:**
- Use `main` for standard development and CI workflows.
- Use `using-selenium-nodes` if you want to experiment with or require a custom Selenium Grid setup not supported by GitHub Actions.

---
