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