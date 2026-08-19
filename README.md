# Theo's Food Trailer Menu

Theo's Food Trailer Menu is a full-stack application built with **C#, .NET, ASP.NET Core, HTML, CSS, and JavaScript**.

The project demonstrates how a frontend application can communicate with an ASP.NET Core REST API to retrieve and dynamically display menu data. It also includes a console client and automated integration testing.

The application now features a custom splash screen and responsive web interface designed to provide a more polished user experience.

---

## Features

- Custom Food Trailer splash screen
- Responsive web interface
- Dynamic menu rendering with JavaScript
- ASP.NET Core Minimal API
- RESTful API endpoints
- Full CRUD operations
- Console application that consumes the API using `HttpClient`
- Asynchronous programming with `async` and `await`
- JSON data communication
- Automated testing with xUnit
- API integration testing with `WebApplicationFactory`
- Static file hosting through ASP.NET Core
- Responsive menu cards
- Menu category and availability display
- Mobile-friendly design

---

## Technologies Used

| Category | Technology |
| --- | --- |
| Language | C# |
| Framework | .NET 10 |
| Backend | ASP.NET Core Minimal API |
| Frontend | HTML5, CSS3, JavaScript |
| API Client | HttpClient / Fetch API |
| Testing | xUnit |
| Integration Testing | WebApplicationFactory |
| Data Format | JSON |
| Version Control | Git & GitHub |
| Development Environment | Visual Studio Code |

---

## Project Structure

```text
food-trailer-menu/
│
├── FoodTrailerMenu.Api/
│   ├── Program.cs
│   │
│   └── wwwroot/
│       ├── index.html
│       │
│       ├── css/
│       │   └── style.css
│       │
│       ├── js/
│       │   └── app.js
│       │
│       └── images/
│           └── food-trailer-splash.png
│
├── FoodTrailerMenu.Console/
│
├── FoodTrailerMenu.Tests/
│
└── FoodTrailerMenu.slnx
```

### FoodTrailerMenu.Api

Contains the ASP.NET Core Minimal API and web frontend.

The API manages menu data and exposes REST endpoints that can be consumed by the browser or other applications.

ASP.NET Core also serves the frontend files from the `wwwroot` directory.

### FoodTrailerMenu.Console

A C# console application that communicates with the API using `HttpClient`.

This project demonstrates API consumption, asynchronous programming, and JSON deserialization.

### FoodTrailerMenu.Tests

Contains automated tests built with **xUnit** and **WebApplicationFactory**.

The tests verify that the API behaves correctly and returns expected responses.

---

## Application Flow

When the application starts, the user is presented with a custom Food Trailer splash screen.

```text
User Opens Website
        ↓
Food Trailer Splash Screen
        ↓
User Clicks "View Menu"
        ↓
JavaScript Sends GET Request
        ↓
GET /api/menu
        ↓
ASP.NET Core Minimal API
        ↓
Menu Data Returned as JSON
        ↓
JavaScript Dynamically Creates Menu Cards
        ↓
Menu Displayed in Browser
```

This demonstrates communication between the **presentation layer** and the **API layer** of the application.

---

## API Endpoints

| HTTP Method | Endpoint | Description |
| --- | --- | --- |
| GET | `/api/menu` | Retrieve all menu items |
| GET | `/api/menu/{id}` | Retrieve a menu item by ID |
| POST | `/api/menu` | Create a new menu item |
| PUT | `/api/menu/{id}` | Update an existing menu item |
| DELETE | `/api/menu/{id}` | Delete a menu item |

---

## CRUD Operations

The API demonstrates the four primary CRUD operations:

| CRUD Operation | HTTP Method | Purpose |
| --- | --- | --- |
| Create | POST | Add a menu item |
| Read | GET | Retrieve menu items |
| Update | PUT | Modify a menu item |
| Delete | DELETE | Remove a menu item |

---

## Frontend

The frontend is located inside:

```text
FoodTrailerMenu.Api/wwwroot/
```

ASP.NET Core serves these files using:

```csharp
app.UseDefaultFiles();
app.UseStaticFiles();
```

The frontend consists of:

```text
index.html
css/style.css
js/app.js
images/food-trailer-splash.png
```

### Splash Screen

When the website first opens, users are presented with a custom **Theo's Food Trailer** splash screen.

Selecting **View Menu** hides the splash screen and opens the main application.

### Dynamic Menu

JavaScript retrieves menu data from the API:

```javascript
const response = await fetch("/api/menu");
const menuItems = await response.json();
```

The returned JSON data is then used to dynamically generate menu cards in the browser.

This means the menu displayed on the website comes directly from the ASP.NET Core API instead of being hard-coded into the HTML.

---

## Running the Application

### Clone the Repository

```bash
git clone https://github.com/tabner0320/food-trailer-menu.git
```

Move into the project:

```bash
cd food-trailer-menu
```

---

## Run the API and Website

From the project root:

```bash
dotnet run --project FoodTrailerMenu.Api
```

The terminal will display the local URL for the application.

For example:

```text
http://localhost:5041
```

Open the URL in your browser.

You should first see the **Theo's Food Trailer splash screen**.

Click:

```text
VIEW MENU
```

to enter the application.

---

## Run the Console Application

With the API running, open another terminal and run:

```bash
dotnet run --project FoodTrailerMenu.Console
```

The console application communicates with the Food Trailer API using `HttpClient`.

---

## Run the Tests

From the solution directory:

```bash
dotnet test
```

Current test result:

```text
Total tests: 13
Passed: 13
Failed: 0
Skipped: 0
```

---

## Build the Solution

Run:

```bash
dotnet build
```

This builds the API, console application, and test project.

---

## What I Learned

Building Theo's Food Trailer Menu gave me hands-on experience with:

- Building REST APIs with ASP.NET Core Minimal API
- Implementing CRUD operations
- Working with HTTP methods
- Using `HttpClient`
- Working with JavaScript `fetch()`
- Sending and receiving JSON data
- Connecting a frontend to a backend API
- Dynamically rendering API data in the browser
- Serving static frontend files with ASP.NET Core
- Using asynchronous programming with `async` and `await`
- Writing automated tests with xUnit
- Performing API integration testing
- Debugging frontend and backend communication
- Organizing a multi-project .NET solution
- Using Git and GitHub for version control
- Designing a responsive web interface

---

## Future Improvements

Possible future improvements include:

- Persistent database storage
- Administrator interface for managing menu items
- Customer ordering functionality
- Shopping cart
- Menu item images
- Additional menu categories
- Authentication and authorization
- Cloud deployment with Microsoft Azure
- Expanded unit and integration test coverage

---

## Author

**Theophilus M. Abner Jr.**

Software Developer | C# | .NET | ASP.NET Core | JavaScript

GitHub: `tabner0320`

---

## Project Purpose

This project was created as part of my continued software development training and portfolio development.

It demonstrates practical experience building and connecting multiple parts of a modern application, including a **web frontend, REST API, console client, and automated test project**.