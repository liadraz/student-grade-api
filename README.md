# Student Grades Management API

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

## Development Concepts Covered

* Built a RESTful API using ASP.NET Core (.NET 8) and Controllers
* Implemented HTTP methods for CRUD operations (GET, POST, PUT, DELETE)
* Designed clean and intuitive API routes
* Used query parameters for filtering (by average), sorting, and pagination
* Separated concerns using DTOs and entity mapping
* Applied validation using data annotations and model state checking
* Added centralized error handling and proper HTTP responses
* Applied asynchronous programming for scalability (async/await)
* Used dependency injection for managing services and database context
* Persisted data using EF Core with PostgreSQL
* Containerized the app using Docker and configured with Docker Compose
* Integrated Swagger for API documentation and testing
