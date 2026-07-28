# Theo's Food Trailer Menu

A .NET application built with **C#**, **ASP.NET Core Minimal API**, and a **Console client** that demonstrates REST API development, asynchronous programming, HTTP communication, and automated testing.

This project contains an ASP.NET Core API that manages food trailer menu data and a console application that consumes the API using `HttpClient`.

---

## Features

* RESTful API built with ASP.NET Core Minimal API
* CRUD operations for menu items
* Console application client that communicates with the API using `HttpClient`
* Asynchronous programming with `async` and `await`
* Integration testing with xUnit and WebApplicationFactory
* JSON-based menu data storage
* API endpoint testing

---

## Technologies Used

| Category        | Technology               |
| --------------- | ------------------------ |
| Language        | C#                       |
| Framework       | .NET 10                  |
| Backend         | ASP.NET Core Minimal API |
| API Client      | HttpClient               |
| Testing         | xUnit                    |
| Data Format     | JSON                     |
| Version Control | Git & GitHub             |
| Editor          | Visual Studio Code       |

---

## Project Structure

```
FoodTrailerMenu.Api/          # ASP.NET Core Web API
FoodTrailerMenu.Console/      # Console application API client
FoodTrailerMenu.Tests/        # Automated tests
FoodTrailerMenu.slnx          # Solution file
README.md
```

---

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/tabner0320/food-trailer-menu.git
```

### Navigate to the Project

```bash
cd food-trailer-menu
```

---

## Run the API

Start the ASP.NET Core API:

```bash
dotnet run --project FoodTrailerMenu.Api
```

The API will start and listen on the configured localhost port.

---

## Run the Console Client

With the API running in another terminal:

```bash
dotnet run --project FoodTrailerMenu.Console
```

The console application sends HTTP requests to the API and displays menu information.

---

## Run Tests

Execute the automated test suite:

```bash
dotnet test
```

Current Results:

* ✅ 13 Tests Passed
* ❌ 0 Failed
* ⏭ 0 Skipped

---

## API Endpoints

| Method | Endpoint         | Description                  |
| ------ | ---------------- | ---------------------------- |
| GET    | `/api/menu`      | Retrieve all menu items      |
| GET    | `/api/menu/{id}` | Retrieve a menu item by ID   |
| POST   | `/api/menu`      | Create a new menu item       |
| PUT    | `/api/menu/{id}` | Update an existing menu item |
| DELETE | `/api/menu/{id}` | Delete a menu item           |

---

## Future Improvements

* Database integration with SQL Server
* Entity Framework Core implementation
* User authentication and authorization
* Admin management features
* Docker containerization
* Azure deployment
* Enhanced API documentation with Swagger

---

## What I Learned

Through this project, I gained experience with:

* Building RESTful APIs with ASP.NET Core
* Creating and consuming HTTP endpoints
* Implementing CRUD operations
* Working with asynchronous programming
* Using HttpClient for API communication
* Writing automated tests with xUnit
* Organizing .NET solutions
* Managing projects with Git and GitHub

---

## Author

**Theophilus Abner**

GitHub: https://github.com/tabner0320

Repository: https://github.com/tabner0320/food-trailer-menu
