var builder = WebApplication.CreateBuilder(args);

// Add Swagger/OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Enable Swagger middleware
app.UseSwagger();
app.UseSwaggerUI();

// ------------------------------------------------------------
// Route Group: Weather
// ------------------------------------------------------------
var weatherGroup = app.MapGroup("/weather")
                      .WithTags("Weather");

// GET /weather
weatherGroup.MapGet("/", () =>
{
    var forecast = new[]
    {
        new WeatherForecast("Boston", 55),
        new WeatherForecast("New York", 60),
        new WeatherForecast("Chicago", 48)
    };

    return Results.Ok(forecast);
})
.WithName("GetWeather")
.WithOpenApi();

// GET /weather/{city}
weatherGroup.MapGet("/{city}", (string city) =>
{
    var random = new Random();
    var temp = random.Next(40, 90);

    return Results.Ok(new WeatherForecast(city, temp));
})
.WithName("GetWeatherByCity")
.WithOpenApi();

app.Run();

// ------------------------------------------------------------
// Supporting record type
// ------------------------------------------------------------
record WeatherForecast(string City, int Temperature);