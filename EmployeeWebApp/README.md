# Employee Web Application

A simple ASP.NET Core Razor Pages web application that displays employee information in a table format.

## Features

- Displays employee information with first names and truncated last names
- Last names are truncated to show only the first 3 characters
- Clean, Bootstrap-styled table interface
- Sample data included with 5 employees

## Requirements

- .NET 9.0 SDK or later

## Running the Application

1. Navigate to the project directory:
   ```bash
   cd EmployeeWebApp
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to:
   - `https://localhost:5001` (HTTPS)
   - `http://localhost:5000` (HTTP)

## Building the Application

To build the application:
```bash
dotnet build
```

## Project Structure

- `Models/Employee.cs` - Employee model with FirstName, LastName, and TruncatedLastName properties
- `Pages/Index.cshtml` - Main page displaying the employee table
- `Pages/Index.cshtml.cs` - Page model containing sample employee data

## Implementation Details

The application uses:
- ASP.NET Core 9.0 Razor Pages
- Bootstrap 5 for styling
- In-memory employee data (no database required)

The last name truncation is implemented using a computed property in the Employee model that returns only the first 3 characters of the last name.
