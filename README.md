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