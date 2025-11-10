# User Search Application

A .NET Blazor Server application for searching and validating user information against an MS SQL database.

## Features

- **User Input Form**: Accepts firstname, lastname, and phone number
- **Database Search**: Queries MS SQL database for matching records
- **Complete Results**: Displays matching users with full address details
- **Interactive UI**: Real-time search with Bootstrap styling
- **Seeded Data**: Includes 5 sample users for testing

## Technology Stack

- .NET 9.0
- Blazor Server (Interactive Server Components)
- Entity Framework Core 9.0
- MS SQL Server / LocalDB
- Bootstrap 5

## Database Schema

### Users Table
- **Id** (int, Primary Key)
- **FirstName** (string, required, max 100 chars)
- **LastName** (string, required, max 100 chars)
- **PhoneNumber** (string, required, max 20 chars)
- **Address** (string, max 500 chars)

## Sample Data

The application comes pre-seeded with the following users:

1. John Doe - 555-1234 - 123 Main St, Springfield, IL 62701
2. Jane Smith - 555-5678 - 456 Oak Ave, Chicago, IL 60601
3. Robert Johnson - 555-9012 - 789 Pine Rd, Naperville, IL 60540
4. Emily Davis - 555-3456 - 321 Elm St, Aurora, IL 60505
5. Michael Brown - 555-7890 - 654 Maple Dr, Peoria, IL 61602

## Setup Instructions

### Prerequisites
- .NET 9.0 SDK or later
- SQL Server or LocalDB

### Installation

1. Clone the repository
2. Navigate to the UserSearchApp directory
3. Update the connection string in `appsettings.json` if needed
4. Run the application:
   ```bash
   dotnet run
   ```

### Database Configuration

The default connection string uses SQL Server LocalDB:
```
Server=(localdb)\\mssqllocaldb;Database=UserSearchDb;Trusted_Connection=True;MultipleActiveResultSets=true
```

For SQL Server, update the connection string in `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=UserSearchDb;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
  }
}
```

## Usage

1. Launch the application
2. Navigate to "User Search" in the navigation menu
3. Enter search criteria:
   - First Name (partial match supported)
   - Last Name (partial match supported)
   - Phone Number (partial match supported)
4. Click "Search" to find matching users
5. View results with complete address information
6. Click "Clear" to reset the search form

## Search Functionality

- **Partial Match**: All search fields support partial matching
- **Multiple Criteria**: Combine firstname, lastname, and phone for refined searches
- **Case Insensitive**: Search is case-insensitive for user convenience
- **Empty Search**: Returns no results if no criteria provided

## Project Structure

```
UserSearchApp/
├── Components/
│   ├── Layout/
│   │   └── NavMenu.razor          # Navigation menu
│   └── Pages/
│       └── UserSearch.razor        # User search page
├── Data/
│   └── ApplicationDbContext.cs     # EF Core DbContext
├── Models/
│   └── User.cs                     # User entity model
├── Migrations/                     # EF Core migrations
├── Program.cs                      # Application entry point
└── appsettings.json                # Configuration
```

## Future Enhancements

- Add user CRUD operations (Create, Update, Delete)
- Implement pagination for large result sets
- Add export functionality (CSV, PDF)
- Implement advanced filtering options
- Add user authentication and authorization
- Support for multiple search result sorting
