using ApiJobs;
using ApiJobs.Models;
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


app.MapGet("/api/jobs", async ([FromServices] JobsContext dbContext) =>
{
    return Results.Ok(dbContext.Jobs.Include(p=> p.Category));
});


app.MapPost("/api/newjob", async ([FromServices] JobsContext dbContext, [FromBody] Job job ) =>
{
    job.JobId = Guid.NewGuid();

    await dbContext.AddAsync(job);
    await dbContext.SaveChangesAsync();

    return Results.Ok();

    
});

app.MapPut("/api/jobs/{id}", async ([FromServices] JobsContext dbContext, [FromBody] Job job, [FromRoute] Guid id ) =>
{
    var currentJob = dbContext.Jobs.Find(id);

    if(currentJob == null){
      return Results.NotFound();
    }


    currentJob.CategoryId = job.CategoryId;
    currentJob.Title = job.Title;
    currentJob.Location = job.Location;
    currentJob.JobType = job.JobType;
    currentJob.Description = job.Description;
    currentJob.IsActive = job.IsActive;


    await dbContext.SaveChangesAsync();
    return Results.Ok();

    
});




app.MapDelete("/api/jobs/{id}", async ([FromServices] JobsContext dbContext, [FromRoute] Guid id ) =>
{
    var currentJob = dbContext.Jobs.Find(id);

    if(currentJob == null){
      return Results.NotFound();
    }

    dbContext.Remove(currentJob);
    await dbContext.SaveChangesAsync();
    
    return Results.Ok();

    
});




app.Run();
