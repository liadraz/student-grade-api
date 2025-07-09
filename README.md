# Student Management API

A backend system built with ASP.NET Core that allows managing students and their grades. The system supports CRUD operations, filtering, sorting, and pagination, and is containerized for easy deployment.

---

## Features

* CRUD operations for student records
* Add and retrieve grades associated with each student
* Filter students by minimum average score
* Sort and paginate student data
* Containerized using Docker
* Integrated with PostgreSQL via Entity Framework Core
* API tested and documented with Swagger

---

## Stack

* ASP.NET Core (.NET 8), Controllers, REST API
* PostgreSQL with Entity Framework Core (ORM)
* Docker for containerization
* Swagger for documentation and testing
* AWS (EC2, EKS) for deployment (optional)

---

## Setup Instructions

1. **Clone the repository**

   ```bash
   git clone https://github.com/your-username/student-grades-api.git
   cd student-grades-api
   ```

2. **Run with Docker Compose**
   Make sure Docker is installed and running.

   ```bash
   docker compose up --build
   ```

3. **Access the API**
   Navigate to:

   ```
   http://localhost:5000/swagger
   ```
---

### Endpoints


| Action         | HTTP Method | Route               | Description                      |
|----------------|-------------|---------------------|----------------------------------|
| Create Student | `POST`      | `/students`         | Add a new student with optional grades |
| Get All        | `GET`       | `/students`         | Retrieve a list of students with optional filtering by average grade, sorting, and pagination |
| Get by ID      | `GET`       | `/students/{id}`    | Retrieve a single student with their grades by unique ID |
| Update         | `PUT`       | `/students/{id}`    | Update a student's basic info and grades |
| Delete         | `DELETE`    | `/students/{id}`    | Remove a student and their associated grades |

#### Example Use Case

A client application can use this API to:

1. Register new students and assign them grades.
2. Display a paginated list of students, sorted by name or average score.
3. Filter students based on a minimum average score to show top performers.
4. View detailed grade breakdown for an individual student.
5. Edit or remove student records as needed.

---

### Development Concepts Covered

- Built a **RESTful API** with **ASP.NET Core (.NET 8)** using **Controllers**
- Implemented **CRUD operations** via HTTP methods: GET, POST, PUT, DELETE
- Designed clean, intuitive **API routes** with query parameters
- Enabled **filtering** (by average score), **sorting**, and **pagination**
- Used **DTOs** and **entity mapping** to separate concerns
- Applied **validation** with data annotations and model state checks
- Implemented **centralized error handling** with appropriate HTTP responses
- Followed **asynchronous programming** best practices (`async/await`)
- Used **dependency injection** to manage services and DbContext
- Persisted data with **Entity Framework Core** and **PostgreSQL**
- **Containerized** the application using **Docker** and **Docker Compose**
- Integrated **Swagger** for API testing and interactive documentation

