# CoffeeTime API - ASP.NET Core

This is a simple **ASP.NET Core Web API** project that exposes a single endpoint to simulate a coffee machine. The project also includes unit tests for all behaviors.

---

## Endpoint

### `GET /brew-coffee`

The endpoint behaves as follows:

1. **Normal call**  
   Returns **200 OK** with a JSON response containing:
   - A status message
   - The current date and time in **ISO-8601** format  

   **Example Response:**

   ```json
   {
     "message": "Your piping hot coffee is ready",
     "prepared": "2026-02-18T10:15:30+00:00"
   }

    Every 5th call
    Returns 503 Service Unavailable with an empty response body, indicating that the coffee machine is out of coffee.

    April 1st (April Fools)
    Returns 418 I’m a teapot with an empty response body, to indicate that the endpoint is not brewing coffee today.

Getting Started
Prerequisites

    .NET 7 SDK

    Visual Studio 2022 (or later) or Visual Studio Code

    Optional: Postman or browser for testing

Running the API

    Clone the repository:

    git clone <repo-url>
    cd coffeeTime

    Restore dependencies:

    dotnet restore

    Run the application:

    dotnet run

    Access the endpoint:

    https://localhost:<port>/brew-coffee

    (Optional) Swagger UI:

    https://localhost:<port>/swagger

Running Tests

The project includes xUnit unit tests for all three scenarios (200, 503, 418).

Run tests via command line:

dotnet test

Or in Visual Studio using Test Explorer → Run All Tests.
Notes

    The project uses a static call counter to track every 5th call.

    For unit tests, the date for April 1st tests is hardcoded to allow reliable testing.

    Visual Studio temporary files (.vs/) and build artifacts are ignored via .gitignore.

License

This project is for educational purposes.


---
