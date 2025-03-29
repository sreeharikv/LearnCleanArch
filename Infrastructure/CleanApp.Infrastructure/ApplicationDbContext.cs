namespace CleanApp.Infrastructure;
using CleanApp.Application;
using CleanApp.Domain.Entity;
using CleanApp.Presentation.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<User>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Gender> Genders { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(EmployeeConfiguration).Assembly);
        builder.ApplyConfigurationsFromAssembly(typeof(GenderConfiguration).Assembly);

        //Insert initial data
        ApplicationDbContextSeed.SeedUser(builder);
        ApplicationDbContextSeed.SeedGender(builder);
        base.OnModelCreating(builder);
    }
}
