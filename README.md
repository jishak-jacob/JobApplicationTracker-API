# JobApplicationTracker-API
ASP.NET Core 9 Web API backend for the Job Application Tracker. Built using Clean Architecture, Entity Framework Core, and supports CRUD operations for managing job applications.

 Features

- RESTful API endpoints (`GET`, `POST`, `PUT`)
- Entity Framework Core with **SQLite** (or switchable to In-Memory DB)
- Clean Architecture structure
- Repository and Service layers
- FluentValidation for input validation
- Global error handling
- Swagger
- Enum-based `ApplicationStatus` (e.g., Applied, Interviewing, Rejected, etc.)
- Unit test support for Repository and Service layers
- Pagination on GET /applications endpoint via query parameters `pageNumber` and `pageSize`.

 Project Structure

JobApplicationTracker/
│
├── JobApplicationTracker.API/ → API layer (Controllers, Program.cs)
├── JobApplicationTracker.Application/ → Application logic (DTOs, Interfaces, Services, Validators)
├── JobApplicationTracker.Domain/ → Domain models/entities
├── JobApplicationTracker.Infrastructure/ → EF Core DB context & Repositories
└── JobApplicationTracker.Tests/ → Unit tests


---

Technologies Used

- .ASP.NET Core 9 Web API
- Entity Framework Core
- FluentValidation
- Swagger UI
- xUnit


