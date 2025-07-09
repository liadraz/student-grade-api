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

## Setup

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

