using ApiJobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

var builder = WebApplication.CreateBuilder(args);


//builder.Services.AddDbContext<JobsContext>(p => p.UseInMemoryDatabase("JobsDB"));
builder.Services.AddNpgsql<JobsContext>(builder.Configuration.GetConnectionString("db_jobs"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

/*app.MapGet("/dbconn", async([FromServices] JobsContext dbContext) => {
    dbContext.Database.EnsureCreated();
    return Results.Ok("Create database connection: " + dbContext.Database.IsInMemory());
});*/

app.MapGet("/dbconn", async ([FromServices] JobsContext dbContext) =>
{
    try
    {
        await dbContext.Database.EnsureCreatedAsync();
        return Results.Ok("Database connection created");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error creating database connection: {ex}");
        return Results.BadRequest("Error creating database connection");
    }
});

app.Run();
