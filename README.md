# The 25th 

A robust, full-stack ASP.NET Core MVC web application built with a strict N-Tier architecture. This project demonstrates clean separation of concerns, relational database management, and cross-project dependency injection.

## 🏗 Architecture
This solution is divided into 5 distinct layers to ensure scalable and maintainable code:
* **The25th_WEB:** The presentation layer (Controllers, Views, MVC Areas).
* **The25th.Business:** Contains the core business logic, services, and interface implementations.
* **The25th.DataAccess:** Manages the Entity Framework Core DbContext and database migrations.
* **The25th.Models:** Holds the data entities (e.g., Category, Product) and database schemas.
* **The25th.Utility:** Stores shared resources, constants, and helper functions.

## 💻 Tech Stack
* **Framework:** .NET 11 / C#
* **Architecture:** MVC (Model-View-Controller) / N-Tier
* **ORM:** Entity Framework Core
* **Database:** SQL Server (Hosted via Docker for macOS development)
* **Frontend:** HTML5, CSS3, Bootstrap

## 🚀 Local Development Setup (macOS)

### Prerequisites
* [.NET SDK](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop/) (for SQL Server)
* Visual Studio Code with the C# Dev Kit

### Installation & Running
1. **Start the Database:**
   Ensure Docker is running and spin up your SQL Server container.
2. **Restore Packages:**
   `dotnet restore`
3. **Apply Database Migrations:**
   From the root directory, apply the DataAccess migrations to the Web startup project:
   `dotnet ef database update --project The25th.DataAccess --startup-project The25th_WEB`
4. **Run the Application:**
   `dotnet run --project The25th_WEB`
   
   Navigate to `http://localhost:5299` (or your configured port) in your browser.
