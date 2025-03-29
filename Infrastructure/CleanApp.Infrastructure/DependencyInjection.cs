using CleanApp.Application;
using CleanApp.Application.Repositories;
using CleanApp.Domain.Entity;
using CleanApp.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection InfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => 
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString"));
        });
        services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>();

        services.AddIdentityCore<User>().AddEntityFrameworkStores<ApplicationDbContext>();

        services.Configure<IdentityOptions>(options => 
        {
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
            options.Lockout.MaxFailedAccessAttempts = 5;
            options.Lockout.AllowedForNewUsers = true;
        });

        services.AddScoped<IAuthenticationRepository, AuthenticationRepository>();
        services.AddScoped<IFactoryRepository, FactoryRepository>();
        return services;
    }
}
