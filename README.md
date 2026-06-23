# Theo's Food Trailer Menu

## Overview

Theo's Food Trailer Menu is a full-stack application built with ASP.NET Core, C#, Node.js, and JavaScript. The project provides a REST API, a console client, and a responsive web interface for viewing and managing food trailer menu items.

This project demonstrates software development concepts including API development, asynchronous programming, automated testing, and front-end web development.

---

## Features

* REST API built with ASP.NET Core Minimal API
* Console application that consumes the API using HttpClient
* Asynchronous programming with `async` and `await`
* Automated testing using xUnit
* Dynamic menu rendering with JavaScript
* Category filtering and search functionality
* Responsive mobile-friendly design
* JSON-based menu data storage
* CRUD operations for menu management

---

## Technologies Used

| Layer           | Technology               |
| --------------- | ------------------------ |
| Front-end       | HTML5, CSS3, JavaScript  |
| Back-end        | ASP.NET Core Minimal API |
| Language        | C#                       |
| API Consumption | HttpClient, async/await  |
| Testing         | xUnit                    |
| Tools           | Git, GitHub, VS Code     |
| Web Server      | Node.js, Express.js      |

---

## Project Structure

```text
FoodTrailerMenu.Api
FoodTrailerMenu.Console
FoodTrailerMenu.Tests
```

### FoodTrailerMenu.Api

Provides REST API endpoints for managing menu items.

### FoodTrailerMenu.Console

Consumes the API and displays menu data using a C# console application.

### FoodTrailerMenu.Tests

Contains automated unit tests built with xUnit.

---

## API Endpoints

| Method | Endpoint            | Description           |
| ------ | ------------------- | --------------------- |
| GET    | /api/menuitems      | Get all menu items    |
| GET    | /api/menuitems/{id} | Get a menu item by ID |
| POST   | /api/menuitems      | Create a menu item    |
| PUT    | /api/menuitems/{id} | Update a menu item    |
| DELETE | /api/menuitems/{id} | Delete a menu item    |

---

## How to Build

```bash
dotnet build
```

---

## Run the ASP.NET Core API

```bash
dotnet run --project FoodTrailerMenu.Api --urls http://localhost:5000
```

Open:

```text
http://localhost:5000/swagger
```

or

```text
http://localhost:5000/api/menuitems
```

---

## Run the Console Application

```bash
dotnet run --project FoodTrailerMenu.Console
```

---

## Run Automated Tests

```bash
dotnet test
```

### Current Test Results

* Total Tests: 5
* Passed: 5
* Failed: 0

---

## Run the Node.js Web Application

Install dependencies:

```bash
npm install
```

Start the server:

```bash
node server/server.js
```

Or use Nodemon:

```bash
npx nodemon server/server.js
```

Open:

```text
http://localhost:3000
```

---

## Sample Menu Item

```json
{
  "id": 1,
  "name": "Burger",
  "category": "Entree",
  "price": 9.99,
  "isAvailable": true
}
```

---

## What Did You Learn From This Project?

This project helped me learn how to build a full-stack application using ASP.NET Core Minimal APIs, C#, JavaScript, and Node.js. I gained experience creating REST endpoints, consuming APIs with HttpClient, implementing asynchronous programming with async and await, and organizing a multi-project solution. I also learned how to write automated tests using xUnit and use Git and GitHub for source control.

---

## What Did You Learn From This Course?

Throughout this course, I learned object-oriented programming concepts, software design principles, API development, automated testing, debugging techniques, and version control practices. I improved my ability to build and deploy applications using the .NET ecosystem and gained confidence working with real-world software development tools.

---

## What Would You Add With More Time?

If I had more time, I would:

* Connect the application to a SQL Server or SQLite database
* Add user authentication and authorization
* Create an administrative dashboard for menu management
* Deploy the application to a cloud platform such as Azure
* Improve the user interface using a modern JavaScript framework
* Add online ordering and checkout functionality
* Add additional automated integration tests

---

## Author

**Theophilus Abner**

GitHub: https://github.com/tabner0320

Repository: https://github.com/tabner0320/food-trailer-menu
