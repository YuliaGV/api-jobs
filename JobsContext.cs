using ApiJobs.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiJobs;

public class JobsContext: DbContext
{
    public DbSet<Category> Categories {get;set;}
    public DbSet<Job> Jobs {get;set;}

    public JobsContext(DbContextOptions<JobsContext> options) : base(options){ }
    
}