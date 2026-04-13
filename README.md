# Module 06 — Minimal API + Swagger Integration

## 📘 What This Module Demonstrates
This module introduces how to integrate **Swagger/OpenAPI** with **ASP.NET Core Minimal APIs**.  
Learners will see how to:

- Register Swagger services using `AddSwaggerGen()`
- Enable Swagger middleware with `UseSwagger()` and `UseSwaggerUI()`
- Organize endpoints using **route groups**
- Add OpenAPI metadata using `.WithOpenApi()`
- Test endpoints interactively through Swagger UI
- Understand how Minimal APIs serialize JSON responses

This module builds directly on the routing concepts from earlier modules and prepares learners for more advanced API documentation and versioning in later modules.

---

## 🚀 How to Run This Module

From the project folder:

```bash
dotnet run
Now listening on: http://localhost:5243
Open SwaggerUI in the browser
http://localhost:5243/swagger
🌦️ Endpoints Demonstrated
[
  { "city": "Boston", "temperature": 55 },
  { "city": "New York", "temperature": 60 },
  { "city": "Chicago", "temperature": 48 }
]

GET /weather/{city}
Returns a dynamic temperature for the specified city.
Each request generates a new random value to demonstrate dynamic API behavior.
Example:
{
  "city": "Boston",
  "temperature": 73
}
🧠 Key Concepts for Learners
- Minimal APIs can be documented automatically using Swagger.
- Route groups help organize related endpoints.
- .WithOpenApi() adds metadata to improve generated documentation.
- Swagger UI provides an interactive way to test endpoints.
- JSON serialization is automatic in Minimal APIs



