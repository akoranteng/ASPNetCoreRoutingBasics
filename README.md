
📘 MinimalApiSwagger — Module 06: Swagger for Minimal APIs
🚀 What This Module Demonstrates
This module introduces Swagger (OpenAPI) support for Minimal APIs in ASP.NET Core.
It builds on the routing concepts from earlier modules and shows how to:
- Enable Swagger and Swagger UI in a Minimal API project
- Add endpoint metadata for better documentation
- Organize endpoints using route groups
- Apply OpenAPI grouping for cleaner API documentation
- Test endpoints interactively through Swagger UI
This module is designed to be clean, modern, and aligned with .NET 8/9/10 Minimal API best practices.

📂 Project Structure
MinimalApiSwagger/
│
├── Program.cs
├── Properties/
├── appsettings.json
└── README.md   ← this file

🧠 Key Concepts in This Module
1. Enabling Swagger in Minimal APIs
You’ll configure:
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


And enable it in the pipeline:
app.UseSwagger();
app.UseSwaggerUI();
2. Adding Endpoint Metadata
Minimal APIs use metadata to describe endpoints:
.MapGet("/weather", () => ...)
.WithName("GetWeather")
.WithOpenApi();

3. Route Groups + Swagger Groups
You’ll group endpoints like:
var weather = app.MapGroup("/weather").WithTags("Weather");


This produces clean, organized Swagger UI sections.

▶️ Running the Project
From the project folder:
dotnet run


Or press F5 in Visual Studio.
Swagger UI will be available at:

https://localhost:{port}/swagger

🌐 Example URLs
Swagger
- /swagger
Weather Endpoints (examples)
- /weather
- /weather/{city}
Grouped Endpoints (after route groups)
- /api/v1/weather
- /api/v1/weather/{city}
These will appear under organized sections in Swagger UI.
















---







---



