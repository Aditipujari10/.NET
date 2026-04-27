# Library Management System - ASP.NET Core CRUD

This project is a beginner-friendly Library Management System built with ASP.NET Core MVC and MySQL. It follows a clean separation of concerns (Models, Views, Controllers) and uses raw SQL queries via `MySql.Data` for simplicity.

## Project Structure
```text
LibraryManagementSystem/
├── Controllers/
│   └── BooksController.cs       # Handles user requests and CRUD logic
├── Models/
│   └── Book.cs                  # Data model with validation
├── Data/
│   └── BookRepository.cs        # MySQL database operations (CRUD)
├── Views/
│   ├── Books/
│   │   ├── Index.cshtml        # Book listing page (Table)
│   │   ├── Create.cshtml       # Add book form
│   │   └── Edit.cshtml         # Edit book form
│   └── Shared/
│       └── _Layout.cshtml       # Main layout and navigation
├── appsettings.json             # Database connection string
└── Program.cs                   # App configuration and routing
```

## 1. Database Setup
Run the following SQL script in your MySQL environment (e.g., MySQL Workbench or Command Line):

```sql
CREATE DATABASE IF NOT EXISTS librarydb;
USE librarydb;

CREATE TABLE IF NOT EXISTS books (
    id INT AUTO_INCREMENT PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    price DOUBLE NOT NULL
);
```

## 2. Configuration
Update the connection string in `appsettings.json` with your MySQL credentials:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=librarydb;user=your_username;password=your_password"
}
```

## 3. How to Run in Visual Studio Code
1. **Open the Project**: Open the `LibraryManagementSystem` folder in VS Code.
2. **Open Terminal**: Go to `Terminal` -> `New Terminal`.
3. **Restore Packages**: Run `dotnet restore`.
4. **Run the App**: Run `dotnet run` or press `F5` (if you have the C# Dev Kit extension installed).
5. **Access the App**: Open your browser and navigate to the URL shown in the terminal (usually `https://localhost:5001` or `http://localhost:5000`).

## Key Features Implemented
- **Full CRUD**: Add, View, Edit, and Delete books.
- **Clean UI**: Built with Bootstrap 5 for a professional look.
- **Validation**: Server-side and Client-side validation for Title, Author, and Price.
- **Feedback**: Success and error messages using `TempData` and Bootstrap Alerts.
- **Beginner Friendly**: Uses `MySql.Data` for direct database interaction, making it easy to understand the data flow.
