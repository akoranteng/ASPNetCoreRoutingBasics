var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// ---------------------------------------------------------
// Module 05: Minimal API Route Groups
// ---------------------------------------------------------

// Base group for all API endpoints
var api = app.MapGroup("/api");

// ---------------------------------------------------------
// Example Group: Products
// ---------------------------------------------------------
var products = api.MapGroup("/products")
                  .WithTags("Products");

// GET /api/products
products.MapGet("/", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop", Price = 1299.99 },
        new { Id = 2, Name = "Mouse", Price = 29.99 }
    };
});

// GET /api/products/{id}
products.MapGet("/{id:int}", (int id) =>
{
    return new { Id = id, Name = $"Product {id}", Price = 99.99 };
});

// ---------------------------------------------------------
// Example Group: Orders
// ---------------------------------------------------------
var orders = api.MapGroup("/orders")
                .WithTags("Orders");

// GET /api/orders
orders.MapGet("/", () =>
{
    return new[]
    {
        new { OrderId = 1001, Total = 250.00 },
        new { OrderId = 1002, Total = 499.99 }
    };
});

// GET /api/orders/{orderId}
orders.MapGet("/{orderId:int}", (int orderId) =>
{
    return new { OrderId = orderId, Total = 199.99 };
});

// ---------------------------------------------------------
// Root endpoint
// ---------------------------------------------------------
app.MapGet("/", () => "Minimal API Route Groups — Module 05");

app.Run();