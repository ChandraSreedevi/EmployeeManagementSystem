
# Employee Management System

A full-stack Employee Management System developed using ASP.NET Core Web API, SQL Server, HTML, CSS, Bootstrap, JavaScript and jQuery.

The application allows users to manage employee records through CRUD operations with a layered backend architecture.

## Project Overview

Employee Management System provides a simple and user-friendly interface to manage employee information.

The frontend communicates with the ASP.NET Core Web API using jQuery AJAX requests. Employee data is stored and managed in SQL Server using Entity Framework Core.

## Features

- View all employees
- View employee details by ID
- Add new employees
- Update employee information
- Delete employees
- Automatic employee list refresh after CRUD operations
- Responsive dashboard interface
- Layered backend architecture

## Technology Stack

### Backend
- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Repository Pattern
- Service Layer

### Frontend
- HTML5
- CSS3
- Bootstrap 5
- JavaScript
- jQuery
- AJAX

### Tools
- Visual Studio
- SQL Server Management Studio
- Postman
- Git
- GitHub

## Project Architecture

The application follows a layered architecture.

```text
Frontend (HTML, CSS, Bootstrap, jQuery)
                 |
                 | AJAX / JSON
                 |
        ASP.NET Core Web API
                 |
          EmployeesController
                 |
           EmployeeService
                 |
         EmployeeRepository
                 |
             AppDbContext
                 |
             SQL Server
```

### Backend Responsibilities

- Controller: Handles HTTP requests and responses.
- Service: Handles business logic.
- Repository: Handles database operations.
- AppDbContext: Manages database communication using Entity Framework Core.

## CRUD API Endpoints

Base URL:

https://localhost:7031/api/employees

| Operation | HTTP Method | Endpoint |
|---|---|---|
| Get all employees | GET | /api/employees |
| Get employee by ID | GET | /api/employees/1 |
| Add employee | POST | /api/employees |
| Update employee | PUT | /api/employees/1 |
| Delete employee | DELETE | /api/employees/1 |

## Sample API Request

### POST - Add Employee

```json
{
  "name": "Ravi Kumar",
  "email": "ravi@gmail.com",
  "department": "IT",
  "salary": 45000
}
```

### PUT - Update Employee

```json
{
  "id": 1,
  "name": "Ravi Kumar",
  "email": "ravi@gmail.com",
  "department": "HR",
  "salary": 50000
}
```

## Database

Database: EmployeeManagementPracticeDB

Table: Employees

Employee fields:

- Id
- Name
- Email
- Department
- Salary

## How to Run the Project

### Prerequisites

- Visual Studio
- .NET SDK compatible with the projects
- SQL Server
- SQL Server Management Studio
- Postman (optional)

### Backend Setup

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Configure the SQL Server connection string in appsettings.json.
4. Ensure the practice database and migrations are configured.
5. Build and run the EmployeeManagementPKAPI project.
6. Open Swagger to test the API endpoints.

### Frontend Setup

1. Run the EmployeeManagementUI project.
2. Configure the API URL in employee.js to match the running API HTTPS port.
3. Ensure the API allows the frontend origin through CORS.
4. Open the frontend in your browser.

### Running Both Projects

Set both projects as Multiple Startup Projects in Visual Studio and select Start for each.

## API Testing

Postman documentation is available here:

Documentation/Postman-API-Testing.md

## Future Enhancements

- DTO implementation
- Model validation
- Global exception handling
- Logging
- JWT authentication and authorization
- Employee search and department filtering
- Dynamic dashboard statistics
- Unit testing

## Author

Chandra Sreedevi

GitHub: https://github.com/ChandraSreedevi

## License

This project is developed for learning and portfolio purposes.
