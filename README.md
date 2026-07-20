# Theo's Food Trailer Menu

A full-stack food trailer menu application built with **ASP.NET Core**, **C#**, and **JavaScript**. This project demonstrates REST API development, asynchronous programming, automated integration testing, and a responsive front-end interface.

---

## Features

- RESTful API built with ASP.NET Core Minimal API
- Full CRUD operations (Create, Read, Update, Delete)
- Console application that consumes the API using HttpClient
- Asynchronous programming with `async` and `await`
- Integration testing with xUnit and WebApplicationFactory
- Dynamic menu rendering with JavaScript
- Category filtering
- Live search
- Responsive mobile-friendly design
- JSON-based menu storage

---

## Technologies Used

| Category | Technology |
|----------|------------|
| Language | C# |
| Framework | .NET 10 |
| Backend | ASP.NET Core Minimal API |
| Frontend | HTML5, CSS3, JavaScript |
| API Client | HttpClient |
| Testing | xUnit |
| Version Control | Git & GitHub |
| Editor | Visual Studio Code |
| Data Storage | JSON |

---

##  Project Structure

```
FoodTrailerMenu.Api/
FoodTrailerMenu.Console/
FoodTrailerMenu.Tests/
README.md
FoodTrailerMenu.slnx
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

### Run the API

```bash
dotnet run --project FoodTrailerMenu.Api
```

The API will start on the configured localhost port.

---

## Run the Console Client

With the API running in another terminal:

```bash
dotnet run --project FoodTrailerMenu.Console
```

---

##  Run the Tests

```bash
dotnet test
```

Current Results:

- ✅ 13 Tests Passed
- ❌ 0 Failed
- ⏭ 0 Skipped

---

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/menu` | Get all menu items |
| GET | `/api/menu/{id}` | Get menu item by ID |
| POST | `/api/menu` | Create a new menu item |
| PUT | `/api/menu/{id}` | Update a menu item |
| DELETE | `/api/menu/{id}` | Delete a menu item |

---

##  Future Improvements

- Database integration with SQL Server
- Entity Framework Core
- User authentication and authorization
- Admin dashboard
- Image uploads for menu items
- Docker support
- Azure deployment
- Swagger customization

---

## What I Learned

Through this project I gained experience with:

- Designing RESTful APIs
- ASP.NET Core Minimal APIs
- HTTP status codes
- CRUD operations
- Asynchronous programming
- HttpClient
- Integration testing using xUnit
- Git and GitHub workflows
- Repository organization and cleanup
- Building maintainable C# applications

---

##  Author

**Theophilus Abner**

- GitHub: https://github.com/tabner0320
- LinkedIn: *(Add your LinkedIn profile URL here)*

---

## 📄 License

This project is for educational and portfolio purposes.
