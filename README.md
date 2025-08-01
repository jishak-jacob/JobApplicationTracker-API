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

JobApplicationTracker-API

- JobApplicationTracker.API/ → API layer (Controllers, Program.cs)
-  JobApplicationTracker.Application/ → Application logic (DTOs, Interfaces, Services, Validators)
-  JobApplicationTracker.Domain/ → Domain models/entities
-  JobApplicationTracker.Infrastructure/ → EF Core DB context & Repositories
-  JobApplicationTracker.Tests/ → Unit tests



Technologies Used

- .ASP.NET Core 9 Web API
- Entity Framework Core
- FluentValidation
- Swagger UI
- xUnit

How to Run the Backend

1. Prerequisites:
   - [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) installed 

2. Clone the repository:
   git clone https://github.com/your-username/JobApplicationTracker-API.git
   cd JobApplicationTracker-API/JobApplicationTracker.API

3. Once the backend is running, you can access the Swagger UI for detailed API documentation and testing at:
http://localhost:5222/swagger


