[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/U2LjJyKI)

# ASP.NET Core MVC Project

This is a basic ASP.NET Core MVC project created with the default template, which includes Bootstrap for styling.

## Prerequisites

- .NET 9.0 SDK or later

## Running the Application

1. Restore dependencies:
   ```
   dotnet restore
   ```

2. Build the project:
   ```
   dotnet build
   ```

3. Run the application:
   ```
   dotnet run
   ```

The application will start on `http://localhost:5000` by default.

## Project Structure

- `Controllers/`: Contains MVC controllers
- `Models/`: Contains data models
- `Views/`: Contains Razor views
- `wwwroot/`: Static files including Bootstrap CSS and JS
- `Program.cs`: Application entry point
- `appsettings.json`: Configuration settings

## Troubleshooting

- Ensure .NET SDK is installed: `dotnet --version`
- If port 5000 is in use, modify `Properties/launchSettings.json` to use a different port
