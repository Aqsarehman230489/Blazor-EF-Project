# Blazor CRUD Application with Entity Framework

This project is a Blazor-based web application that uses Entity Framework (Code-First approach) to interact with a SQL Server database. The application allows an admin to perform CRUD (Create, Read, Update, Delete) operations on products, which are displayed on the frontend. It also includes a login and registration system, validated by the database.


## Project Overview

This project is made to learn Entity Framework and .NET technologies by implementing a Blazor application with a SQL Server database. It performs basic CRUD operations on products, and includes a login and registration system.

### Main Features
- **CRUD Operations**: Admins can add, update, and delete products in the system.
- **Product Display**: Products are shown in card format with product details.
- **Login and Registration**: Users can log in and register, with credentials validated against the database.
  
---

## Technologies Used

- **Blazor**: For building the user interface.
- **Entity Framework Core**: For data access and database management using Code-First approach.
- **SQL Server**: Database for storing products and user information.
- **Swagger**: For API documentation and testing.
- **ASP.NET Core**: For backend functionality, including authentication and CRUD operations.

---

## Database Structure

The project uses a SQL Server database. The database schema is defined in the project, and the `script.sql` file contains the database schema and initial data.

### Database Features
- **Products Table**: Stores information about products including name, price, description, etc.
- **Users Table**: Stores user information for authentication and registration.

---

## How to run this project in your local system

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/Blazor-EF-Project.git
    ```

2. Navigate into the project directory:

    ```bash
    cd Blazor-EF-Project
    ```

3. Open the project in Visual Studio.

4. Make sure that you have SQL Server running and accessible.

---

## Migration Commands

To set up the database using Entity Framework, follow these steps:

1. Open a terminal or Package Manager Console in Visual Studio.
2. Delete the existing Migration folder
3. change the server name with your server name 

4. Run the following commands to add migrations and update the database:

    ```bash
    # Add the initial migration
    add-Migration InitialMigration
    
    # Update the database to apply the migration
    update-database
    ```

These commands will generate and apply the migrations, creating the database based on the `DbContext` class in the project.
 ![Screenshot](wwwroot/images/Home.jpg)
 <img src="images/Home.jpg" alt="Screenshot" width="500"/>




