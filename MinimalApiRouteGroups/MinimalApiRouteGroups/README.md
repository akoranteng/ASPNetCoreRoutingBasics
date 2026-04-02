# Module 05 — Minimal API Route Groups

This module introduces **Route Groups** in ASP.NET Core Minimal APIs using .NET SDK 10.  
Route Groups allow you to organize related endpoints under a common prefix, apply shared metadata, and prepare your API for real‑world structure, versioning, and middleware.

---

## 🚀 What You Will Learn

- How to create route groups using `MapGroup()`
- How to organize endpoints by domain (e.g., `/products`, `/orders`)
- How to apply tags for Swagger/OpenAPI grouping
- How to structure clean, modular Minimal API projects
- How route groups prepare you for:
  - Nested groups  
  - Group-level middleware  
  - Group-level authorization  
  - API versioning  

---

## 📁 Project Structure

## 🧩 Route Group Examples

## 🧩 Route Group Examples

### Base API group
```csharp
var api = app.MapGroup("/api");

### Base API group
```csharp
var api = app.MapGroup("/api");

PRoducts group
var products = api.MapGroup("/products")
                  .WithTags("Products");
Orders Group
var orders = api.MapGroup("/orders")
                .WithTags("Orders");

🌐 Example Endpoints
Products
|  |  |  | 
|  | /api/products |  | 
|  | /api/products/{id} |  | 


Orders
|  |  |  | 
|  | /api/orders |  | 
|  | /api/orders/{orderId} |  |

▶️ Running the Project
From the project folder:
dotnet run


Then visit:
- http://localhost:5000
- http://localhost:5000/api/products
- http://localhost:5000/api/orders














