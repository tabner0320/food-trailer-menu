# Theo's Food Trailer Menu

A C# and .NET application that demonstrates building an ASP.NET Core Minimal API and creating a console client that communicates with the API using `HttpClient`.

This project demonstrates REST API development, asynchronous programming, automated testing, and communication between .NET applications.

---

## Features

* RESTful API built with ASP.NET Core Minimal API
* Console application that consumes the API using `HttpClient`
* Asynchronous programming with `async` and `await`
* Automated testing with xUnit
* API integration testing with WebApplicationFactory
* In-memory menu data storage
* Full CRUD operations (Create, Read, Update, Delete) for menu items

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
FoodTrailerMenu.Api/
│   ASP.NET Core Minimal API

FoodTrailerMenu.Console/
│   Console application using HttpClient

FoodTrailerMenu.Tests/
│   xUnit integration tests

FoodTrailerMenu.slnx
README.md
```

---

## Getting Started

### Clone the repository

```bash
git clone https://github.com/tabner0320/food-trailer-menu.git
```

### Navigate to the project

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

## Run the Console Application

With the API running, open another terminal window and run:

```bash
dotnet run --project FoodTrailerMenu.Console
```

The console application will send requests to the API and display the returned menu data.

---

## Run Tests

Run the automated tests with:

```bash
dotnet test
```

Test coverage includes validating API functionality and application behavior.

---

## API Endpoints

The API exposes the following endpoints for managing menu items:

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/menu` | Retrieve all menu items |
| GET | `/api/menu/{id}` | Retrieve a menu item by ID |
| POST | `/api/menu` | Add a new menu item |
| PUT | `/api/menu/{id}` | Update an existing menu item |
| DELETE | `/api/menu/{id}` | Delete a menu item |

---

## API Communication

The application flow:

```text
FoodTrailerMenu.Console
          |
          | HTTP Requests (HttpClient)
          ↓
FoodTrailerMenu.Api
          |
          ↓
Menu Data
```

---

## Future Improvements

* Add SQL Server database integration
* Implement Entity Framework Core
* Add authentication and authorization
* Create an administrative management interface
* Add Docker support
* Deploy API to Azure

---

## What I Learned

Through this project I gained experience with:

* Building RESTful APIs with ASP.NET Core
* Creating Minimal APIs
* Using HttpClient for API communication
* Working with asynchronous programming
* Writing automated tests with xUnit
* Understanding API request and response flow
* Managing projects with Git and GitHub
* Organizing .NET solutions

---

## Author

**Theophilus Abner**

GitHub: <https://github.com/tabner0320>

Repository: <https://github.com/tabner0320/food-trailer-menu>
