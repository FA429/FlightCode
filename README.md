# FlightCode Booking Management System.

## 

The FlightCode booking management website offers a variety of features to facilitate the management of flights and passengers. Users can:
- Add a new flight
- Delete an existing flight
- Modify the details of an existing flight
- Add a new passenger
- Delete a passenger
- Modify passenger data
- Use advanced search to easily find flights and passengers
- Add passengers to existing flights

This system simplifies and efficiently manages all aspects of flight bookings.

## Getting Started

To work on the FlightCode project using ASP.NET MVC and SQL Server in Visual Studio Code (VS Code), follow these simple steps:

### Prerequisites

Make sure you have the following installed on your system:
- [Visual Studio Code](https://code.visualstudio.com/)
- [ASP.NET Core SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

### Installation

1. Clone the Repository:
   Open your terminal and run the following command to clone the repository:
     git clone https://github.com/FA429/FlightCode.git
   
2. Navigate to the Project Directory:
     cd FlightCode
   
3. Restore Dependencies:
   Run the following command to restore the necessary dependencies:
     dotnet restore
   
### Setting Up SQL Server

1. Start SQL Server:
   Ensure your SQL Server instance is running.

2. Create Database:
   Open SQL Server Management Studio (SSMS) and create a new database for the project.

3. Update Connection String:
   Open appsettings.json in the project directory and update the connection string to point to your SQL Server instance and database.

     "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
   }
   
4. Apply Migrations:
   Run the following command to apply database migrations:
     dotnet ef database update
   
### Running the Project

1. Open the Project in VS Code:
     code .
   
2. Run the Application:
   Run the following command in the terminal to start the application:
     dotnet run
   
   This will start the application, and you can view it in your browser at http://localhost:5000.

### Project Structure

- `Controllers/`: Contains the controller classes for handling HTTP requests.
- `Models/`: Contains the data models.
- `Views/`: Contains the Razor views for the UI.
- `wwwroot/`: Contains static files like CSS and JavaScript.
- `appsettings.json`: Configuration settings including connection strings.
- `Program.cs`: Entry point of the application.
- `Startup.cs`: Configures services and the app's request pipeline.

### Scripts

- dotnet restore: Restores the dependencies.
- dotnet build: Builds the application.
- dotnet run: Runs the application.
- dotnet ef migrations add <MigrationName>: Adds a new migration.
- dotnet ef database update: Applies the migrations to the database.

### 
