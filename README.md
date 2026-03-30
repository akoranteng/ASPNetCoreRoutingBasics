# RazorPagesRoutingDemo

This project demonstrates routing in ASP.NET Core using **Razor Pages**, a page-focused programming model built on top of the ASP.NET Core routing system.  
It highlights folder-based routing, page handlers, route templates, and how Razor Pages differ from MVC and Minimal APIs.

---

## 📘 What You Will Learn

By exploring this project, you will understand:

- How Razor Pages use **folder and file structure** to define routes  
- How to define **custom route templates** using `@page` directives  
- How **page handlers** (`OnGet`, `OnPost`, etc.) map to HTTP verbs  
- How route parameters work in Razor Pages  
- How Razor Pages compare to MVC and Minimal APIs  
- How Razor Pages fit into the broader ASP.NET Core routing pipeline  

This project completes the routing foundation started in MinimalApiDemo and MvcRoutingDemo.

---

## 🧩 Key Routing Examples

This project includes examples of:

- Default Razor Page routing  
- Custom route templates using `@page "{id:int}"`  
- Page handlers for GET, POST, and other verbs  
- Passing route parameters to page models  
- Folder-based routing conventions  
- Returning data from page handlers  

Each example is designed to be simple, clear, and easy to extend.

---

## ▶️ Running the Project

From the command line:

```bash
cd RazorPagesRoutingDemo
dotnet run
