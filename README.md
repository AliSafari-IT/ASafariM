# ASafariM Backend

Date: 2025-01-14
Updated: 2025-01-14

ASafariM Backend is a robust and scalable application built with **ASP.NET Core 9**, designed to provide APIs and backend logic for a project management platform. This backend adheres to **Clean Architecture** principles, ensuring maintainability and extensibility.

## Features

### General Features
- **Scalable Architecture**: Modular and scalable design using Clean Architecture.
- **Role-Based Access Control (RBAC)**: Supports multiple user roles like Admin, Manager, and User with specific permissions.
- **Secure Authentication and Authorization**: Implements JWT for secure API access.
- **Real-Time Updates**: Provides real-time notifications using SignalR.
- **API Documentation**: Self-documented APIs using Swagger/OpenAPI.
- **Health Monitoring**: Integrated health checks for system monitoring.
- **Error Handling**: Middleware for global error handling and logging.

---

## Tech Stack

### Backend
- **Framework**: ASP.NET Core 9
- **Database**: MySQL (via Entity Framework Core)
- **Authentication**: JSON Web Tokens (JWT)
- **Real-Time Communication**: SignalR
- **Testing**: xUnit for unit tests and TestCafe for End-to-End tests

### DevOps
- **Workspace Management**: Nx Workspace
- **CI/CD**: GitHub Actions
- **Deployment**: NGINX on Ubuntu VPS

---

## Workspace Structure

### Applications
- `ASafariM.Api`: ASP.NET Core backend project with API logic and controllers.

### Libraries
- `ASafariM.Domain`: Core domain models and business logic.
- `ASafariM.Infrastructure`: Shared infrastructure services like database access, caching, and email services.
- `ASafariM.Application`: Use cases and application-specific logic.

---

## Prerequisites

Ensure the following tools are installed on your system:
- **.NET SDK** (v9.0+)
- **MySQL** (v8.0+)
- **Node.js** (v16.14.0+)
- **Yarn** (v4.5.1)

---

## Setup

### Clone the Repository

```bash
$ git clone https://asafarim-website@dev.azure.com/asafarim-website/asafarim/_git/asafarim
$ cd asafarim
```

### Install Dependencies

```bash
$ yarn install
```

### Database Setup

1. Configure your MySQL connection in `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=asmDB;User=ali;Password=Ali+123456/;"
  }
}
```

2. Apply database migrations:

```bash
$ cd ASafariM.Api
$ dotnet ef database update
```

### Start the Backend

```bash
$ yarn dev:backend
```

---

## API Endpoints

### Authentication
- `POST /api/auth/login`: User login
- `POST /api/auth/register`: User registration
- `POST /api/auth/logout`: User logout

### Projects
- `GET /api/projects`: Get all projects
- `POST /api/projects`: Create a new project
- `PUT /api/projects/{id}`: Update an existing project
- `DELETE /api/projects/{id}`: Delete a project

### Tasks
- `GET /api/tasks`: Get all tasks
- `POST /api/tasks`: Create a new task
- `PUT /api/tasks/{id}`: Update an existing task
- `DELETE /api/tasks/{id}`: Delete a task

### Health Check
- `GET /health`: Health check endpoint

---

## Testing

### Run Unit Tests

```bash
$ cd apps/backends/ASafariM.Server
$ dotnet test
```

### Run End-to-End Tests

```bash
$ cd e2e/tests
$ testcafe chrome tests/**/*.test.js
```

---

## Deployment

### Build the Backend

```bash
$ yarn build:backend
```

### Publish the Backend

```bash
$ dotnet publish -c Release -o ./dist
```

### Deploy to Server

1. Copy the `dist` folder to your server.
2. Configure NGINX to proxy requests to your backend.

Example NGINX configuration:

```nginx
server {
    listen 80;
    server_name asafarim.com;

    location / {
        proxy_pass http://localhost:5000;
        proxy_set_header Host $host;
        proxy_set_header X-Real-IP $remote_addr;
        proxy_set_header X-Forwarded-For $proxy_add_x_forwarded_for;
    }
}
```

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Contributing

Contributions are welcome! Follow these steps:

1. Fork the repository.
2. Create a new branch:

```bash
$ git checkout -b feature-name
```

3. Commit your changes and push them to your fork.
4. Open a pull request.

---

## Contact

For inquiries or support, contact:
- **Email**: [asafarim@outlook.com](mailto:asafarim@outlook.com)
- **Azure DevOps**: [asafarim](https://dev.azure.com/asafarim-website)

