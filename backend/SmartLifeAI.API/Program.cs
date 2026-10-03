using Microsoft.EntityFrameworkCore;
using SmartLifeAI.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Connect Entity Framework Core to SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")));

// Enable API Controllers
builder.Services.AddControllers();

// Allow Flutter Chrome app to communicate with the API
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFlutter", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Test the connection to the SmartLifeAI database
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    if (db.Database.CanConnect())
    {
        Console.WriteLine("SUCCESS: Connected to SmartLifeAI database!");
    }
    else
    {
        Console.WriteLine("ERROR: Could not connect to SmartLifeAI database.");
    }
}

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// Allow Flutter Chrome to access the API
app.UseCors("AllowFlutter");

app.UseHttpsRedirection();

// Enable API Controllers
app.MapControllers();

// Test endpoint
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild",
    "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}