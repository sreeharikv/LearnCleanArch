using CleanApp.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CleanApp.Application;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);

    DbSet<Employee> Employees { get; set; }

    DbSet<Gender> Genders { get; set; }
}
