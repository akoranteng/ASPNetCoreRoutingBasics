# MinimalApiDemo

This project demonstrates the fundamentals of routing in ASP.NET Core using **Minimal APIs**.  
It focuses on endpoint routing, route templates, route constraints, and lightweight HTTP handler patterns introduced in .NET 6 and refined through .NET 8–10.

---

## 📘 What You Will Learn

By exploring this project, you will understand:

- How Minimal APIs use **endpoint routing** to map URLs to handlers  
- How to define **route templates** with parameters  
- How to apply **route constraints** (e.g., `{id:int}`)  
- How to return JSON, text, and typed results  
- How Minimal APIs differ from MVC and Razor Pages routing  
- How Minimal APIs fit into the broader ASP.NET Core routing system  

This project is intentionally simple and focused so learners can build a strong mental model before moving to MVC and Razor Pages.
📘 ASP.NET Core Minimal API — Routing & Formatting Examples
This project demonstrates how to build clean, focused Minimal API endpoints in ASP.NET Core. It introduces routing fundamentals, culture‑aware formatting, and friendly text output — all designed to help learners understand the power and simplicity of Minimal APIs.

🚀 What This Project Demonstrates
This module introduces the foundational concepts behind Minimal APIs and shows how to build small, expressive endpoints that are easy to understand and extend.
Key concepts covered:
- Defining Minimal API endpoints
- Using route parameters and constraints
- Returning plain text vs. JSON
- Formatting dates and times
- - Formatting currency using different cultures
- Handling invalid culture codes gracefully
- Organizing endpoints for clarity and teaching
This project serves as a stepping stone toward more advanced modules such as route groups, filters, versioning, and CRUD operations

🌐 Example URLs for Each Endpoint
Assuming the app is running at:
https://localhost:7043


Adjust the port as needed.

🟦 Basic Endpoints
|  |  | 
|  | https://localhost:7043/hello | 
|  | https://localhost:7043/date | 
|  | https://localhost:7043/time | 

🟩 Date & Time Formatting Endpoints
|  |  | 
|  | https://localhost:7043/date/en-US | 
|  | https://localhost:7043/time/fr-FR |

🟧 Currency Formatting Endpoint
|  |  | 
|  | https://localhost:7043/currency/en-US/1234.56 | 
|  | https://localhost:7043/currency/ja-JP/5000 | 
|  | https://localhost:7043/currency/xyz/100 | 


Sample output:
English (United States) (en-US) formats 1234.56 as $1,234.56


▶️ How to Run This Project
- Clone the repository
- Navigate to the project folder
- Run the application:

- dotnet run

- - Open a browser and test the example URLs above

- 




















---

## 🧩 Key Routing Examples

This project includes examples of:

- Basic GET endpoints  
- Parameterized routes  
- Route constraints  
- POST, PUT, and DELETE handlers  
- Minimal API conventions and patterns  

Each example is designed to be easy to read, modify, and extend.

---

## ▶️ Running the Project

From the command line:

```bash
cd MinimalApiDemo
dotnet run
