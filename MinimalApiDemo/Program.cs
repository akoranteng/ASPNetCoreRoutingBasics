using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// -----------------------------------------
// Basic Routes
// -----------------------------------------

app.MapGet("/", () => "Welcome to the Minimal API Routing Demo!");

app.MapGet("/hello", () => "Hello from the API!");

app.MapGet("/time", () => DateTime.Now.ToString());

// -----------------------------------------
// Route Parameters
// -----------------------------------------

app.MapGet("/greet/{name}", (string name) =>
    $"Hello, {name}! Welcome to the API.");

app.MapGet("/square/{number:int}", (int number) =>
    $"The square of {number} is {number * number}.");

app.MapGet("/repeat/{word}/{count:int}", (string word, int count) =>
    string.Join(" ", Enumerable.Repeat(word, count)));

// -----------------------------------------
// Optional Parameters
// -----------------------------------------

app.MapGet("/optional/{value?}", (string? value) =>
    value is null ? "No value provided." : $"You sent: {value}");

// -----------------------------------------
// Multiple Route Templates
// -----------------------------------------

app.MapGet("/status", () => "OK");
app.MapGet("/health", () => "Healthy");

// -----------------------------------------
// Query Strings
// -----------------------------------------

app.MapGet("/search", (string? q) =>
    q is null ? "No search term provided." : $"You searched for: {q}");

app.MapGet("/datetime/shortdate", () =>
    DateTime.Now.ToString("MM/dd/yyyy"));

app.MapGet("/datetime/longdate", () =>
    DateTime.Now.ToString("dddd, MMMM dd, yyyy"));

app.MapGet("/datetime/time12", () =>
    DateTime.Now.ToString("hh:mm tt"));

app.MapGet("/datetime/time24", () =>
    DateTime.Now.ToString("HH:mm"));

app.MapGet("/datetime/monthyear", () =>
    DateTime.Now.ToString("MMM-yyyy"));

app.MapGet("/datetime/friendly", () =>
    DateTime.Now.ToString("MMMM dd, yyyy 'at' hh:mm tt"));
//Currency 
app.MapGet("/currency/{culture}/{amount:decimal}", (string culture, decimal amount) =>
{
    try
    {
        var ci = new CultureInfo(culture);
        var formatted = amount.ToString("C", ci);

        var message = $"{ci.DisplayName} ({culture}) formats {amount} as {formatted}";

        return Results.Text(message);
    }
    catch (CultureNotFoundException)
    {
        return Results.BadRequest($"Invalid culture code: {culture}");
    }
});



//Display only the formatted value


// -----------------------------------------
app.Run();