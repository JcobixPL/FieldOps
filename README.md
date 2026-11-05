
# FieldOps

**FieldOps** is a weather-based outdoor work planning application built with .NET 10 and ASP.NET Core.

The application helps users find suitable time windows for outdoor activities by analyzing real weather forecasts against user-defined requirements.

> **Status:** Work in progress — initial development

## Tech Stack

### Backend
- C#
- .NET 10
- ASP.NET Core Web API

### Planned Technologies
- Entity Framework Core
- Microsoft SQL Server
- Docker
- Open-Meteo REST API
- React
- TypeScript
- Vite
- xUnit
- GitHub Actions
- Microsoft Azure

## Architecture

The backend follows a layered architecture with separation of responsibilities between Domain, Application, Infrastructure and API.

```text
src/
├── FieldOps.Api/
├── FieldOps.Application/
├── FieldOps.Domain/
└── FieldOps.Infrastructure/
```

## Planned Features

- Create outdoor work tasks with custom weather requirements
- Search for locations using Open-Meteo Geocoding API
- Retrieve weather forecasts from Open-Meteo
- Validate weather conditions against user-defined limits
- Find continuous time windows suitable for completing tasks
- Rank available time windows and recommend the best option
- Store tasks and analysis results in SQL Server
- Display recommendations through a React frontend

## Future Improvements

- Reusable weather requirement templates
- Support for work interruptions and multi-day tasks
- Historical weather forecast analysis and trend detection
- AI-assisted configuration of weather requirements
- AI-generated explanations and reports
- Integration tests and automated CI
- Optional cloud deployment to Microsoft Azure

## Goal

The goal of FieldOps is to develop practical C# and .NET backend engineering skills through real-world API integration, data processing, algorithms, database persistence and automated testing.

The project focuses on solving a specific scheduling problem while keeping the business domain manageable and the architecture maintainable.
