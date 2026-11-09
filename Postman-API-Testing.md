
# Employee Management API - Postman Testing

## Base URL

https://localhost:7031/api/employees

## API Endpoints

| Operation | HTTP Method | Endpoint |
|---|---|---|
| Get All Employees | GET | /api/employees |
| Get Employee By ID | GET | /api/employees/1 |
| Add Employee | POST | /api/employees |
| Update Employee | PUT | /api/employees/1 |
| Delete Employee | DELETE | /api/employees/1 |

## 1. GET - All Employees

Method: GET

URL:
https://localhost:7031/api/employees

Expected Status: 200 OK

## 2. GET - Employee By ID

Method: GET

URL:
https://localhost:7031/api/employees/1

Expected Status: 200 OK

## 3. POST - Add Employee

Method: POST

URL:
https://localhost:7031/api/employees

Body → raw → JSON

{
    "name": "Ravi Kumar",
    "email": "ravi@gmail.com",
    "department": "IT",
    "salary": 45000
}

Expected Status: 201 Created

## 4. PUT - Update Employee

Method: PUT

URL:
https://localhost:7031/api/employees/1

Body → raw → JSON

{
    "id": 1,
    "name": "Ravi Kumar",
    "email": "ravi@gmail.com",
    "department": "HR",
    "salary": 50000
}

Expected Status: 204 No Content

## 5. DELETE - Delete Employee

Method: DELETE

URL:
https://localhost:7031/api/employees/1

Expected Status: 204 No Content

## Technology Stack

- ASP.NET Core Web API
- C#
- SQL Server
- Entity Framework Core
- Repository Pattern
- Service Layer
- JavaScript
- jQuery AJAX
- HTML5
- CSS3
- Bootstrap

## Architecture

React is not used in this project.

Frontend → jQuery AJAX → ASP.NET Core Web API
→ Controller → Service → Repository → SQL Server
