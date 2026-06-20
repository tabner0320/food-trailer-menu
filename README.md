Theo’s Food Trailer Menu

Theo’s Food Trailer Menu is a full-stack application built with ASP.NET Core, C#, Node.js, and JavaScript. The project demonstrates REST API development, asynchronous programming, automated testing, and responsive front-end web design.

---

Features

- REST API built with ASP.NET Core Minimal API
- Console application that consumes the API using `HttpClient`
- Async programming with `async` and `await`
- Automated testing using xUnit
- Dynamic menu rendering with JavaScript
- Category filtering and live search
- Responsive mobile-friendly layout
- JSON-based menu data storage

---

Technologies Used

| Layer | Technology |
|--------|-------------|
| Front-end | HTML5, CSS3, Vanilla JavaScript |
| Back-end | ASP.NET Core Minimal API, Node.js, Express.js |
| Language | C# |
| API Consumption | HttpClient, async/await |
| Testing | xUnit |
| Tools | Git, GitHub, VS Code, Nodemon |

---

Projects

- `FoodTrailerMenu.Api`
- `FoodTrailerMenu.Console`
- `FoodTrailerMenu.Tests`

---

How to Build

```bash
dotnet build
Run the ASP.NET API
dotnet run --project FoodTrailerMenu.Api --urls http://localhost:5000

Open:

http://localhost:5000/api/menu
Run the Console Application
dotnet run --project FoodTrailerMenu.Console
Run Automated Tests
dotnet test
Run the Node.js Web App

Install dependencies:

npm install

Start the server:

node server/server.js

Or use Nodemon:

npx nodemon server/server.js

Open:

http://localhost:3000

## What did you learn from this project?

This project helped me learn how to build a full-stack application using ASP.NET Core Minimal APIs, C#, JavaScript, and Node.js. I gained experience creating REST endpoints, consuming APIs with HttpClient, implementing asynchronous programming with async and await, and organizing a multi-project solution. I also learned how to write automated tests using xUnit and use Git and GitHub for source control.

## What did you learn from this course?

Throughout this course, I learned object-oriented programming concepts, software design principles, API development, automated testing, debugging techniques, and version control practices. I also improved my ability to build and deploy applications using the .NET ecosystem and gained confidence working with real-world software development tools.

## If you had more time, what would you have done differently or what additional features would you have added?

If I had more time, I would add a database to persist menu items instead of using JSON files, implement full CRUD functionality, add user authentication and authorization, create an administrative dashboard for menu management, and deploy the application to a cloud hosting platform. I would also improve the user interface with a modern JavaScript framework and add online ordering capabilities.
