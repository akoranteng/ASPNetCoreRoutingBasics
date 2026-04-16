📘 MvcRoutingDemo — ASP.NET Core Routing Basics (Module 02)
🚀 What This Module Demonstrates
This module introduces ASP.NET Core MVC routing, focusing on how controllers and actions map to URLs. It builds on the Minimal API routing concepts from Module 01 and prepares learners for Razor Pages and advanced routing patterns.
You will learn:
• 	How MVC routing works using controllers and actions
• 	How route templates map to URL patterns
• 	How to use attribute routing
• 	How to pass route parameters
• 	How default routes work in MVC
• 	How to test routes using the browser and query strings
This module is intentionally simple and focused — perfect for teaching the fundamentals of MVC routing.

📂 Project Structure
MvcRoutingDemo/
│
├── Controllers/
│   └── HomeController.cs
│
├── Views/
│   └── (optional if using MVC without views)
│
├── Program.cs
├── appsettings.json
└── README.md   ← this file
 Key Routing Concepts in This Module
1. Conventional Routing
The default MVC route pattern:
/{controller=Home}/{action=Index}/{id?}


This means:
- / → HomeController.Index()
- /Home/About → HomeController.About()
- /Products/Details/5 → ProductsController.Details(5)

2. Attribute Routing
Controllers can define their own routes:
[Route("api/products")]
public class ProductsController : Controller
{
    [HttpGet]
    public IActionResult GetAll() => Ok("All products");

    [HttpGet("{id}")]
    public IActionResult GetById(int id) => Ok($"Product {id}");
}
3. Route Parameters
Examples:
- /products/details/10
- /blog/2024/05/01

▶️ Running the Project
From the project folder:
dotnet run


Or press F5 in Visual Studio.
The app will launch at:
https://localhost:{port}/

Conventional Routing
- /
- /Home/Index
- /Home/About
- /Products/Details/5
Attribute Routing (if included)
- /api/products
- /api/products/10
Example Controller (for reference)
public class HomeController : Controller
{
    public IActionResult Index() => Content("Welcome to MVC Routing Demo");

    public IActionResult About() => Content("About page");
}



📚 Learning Goals
By the end of this module, learners should understand:
- How MVC routing differs from Minimal API routing
- How controllers and actions map to URLs
- How to use attribute routing
- How to pass route parameters







