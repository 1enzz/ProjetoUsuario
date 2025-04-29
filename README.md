# User Management API

This project is designed to help learn and solidify concepts related to building a Web API using **.NET**. It covers key concepts like **RESTful services**, **CRUD operations**, and integration with a **repository pattern** for data management.

## Description

The **User Management API** allows for managing users with basic operations:
- **Create** a new user
- **Read** user information by ID or get all users
- **Update** existing user data
- **Delete** users by ID

This project serves as a practice environment for learning about the architecture of **Web API** applications and how to structure them using the **Repository Pattern** and **Service Layer** in **.NET Core**.

## Features

- **CRUD Operations** (Create, Read, Update, Delete) for users
- **JSON Data Handling** using **ASP.NET Core**
- API routes with RESTful conventions
- Integrated with a simple in-memory repository

## Technologies Used

- **.NET 6 / 7 / 8** (depending on your setup)
- **C#**
- **ASP.NET Core**
- **Swagger** for API documentation
- **In-memory data storage** (for simplicity)

## Installation

To run this project locally, follow the steps below:

1. Clone the repository:

    ```bash
    git clone https://github.com/your-username/ProjetoUsuarios.git
    ```

2. Navigate to the project directory:

    ```bash
    cd ProjetoUsuarios
    ```

3. Restore the dependencies:

    ```bash
    dotnet restore
    ```

4. Run the project:

    ```bash
    dotnet run
    ```

5. Open `http://localhost:5000` or `https://localhost:5001` in your browser to test the API.

6. Access Swagger UI at:

    `https://localhost:5001/swagger`

## API Endpoints

- **GET** `/users` - Retrieve a list of all users.
- **GET** `/users/{id}` - Retrieve a user by their ID.
- **POST** `/users` - Create a new user.
- **PUT** `/users/{id}` - Update an existing user by their ID.
- **DELETE** `/users/{id}` - Delete a user by their ID.

## Example Request and Response

### Create a User (POST /users)

#### Request Body:

```json
{
  "id": 1,
  "name": "John Doe",
  "email": "johndoe@example.com"
}
