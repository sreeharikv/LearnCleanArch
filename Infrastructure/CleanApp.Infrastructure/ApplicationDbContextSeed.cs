using CleanApp.Domain.DTO;
using CleanApp.Domain.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CleanApp.Infrastructure;

public class ApplicationDbContextSeed
{
    private static Guid GuidSuperAdmin01 = Guid.NewGuid();

    private static User user = new User()
    {
        Id = GuidSuperAdmin01.ToString(),
        FirstName = "System",
        LastName = "Admin",
        UserName = "admin@system.com",
        Email = "admin@system.com",
        EmailConfirmed = true,
        LockoutEnabled = false,
        PhoneNumber = "2027708556",
        IsActive = true,
        CreatedBy = "Maual",
        CreatedDate = DateTime.Now
    };

    public static void SeedUser(ModelBuilder builder)
    {
        Guid roleSuperAdmin01 = Guid.NewGuid();
        Guid roleAdmin02 = Guid.NewGuid();
        Guid roleUser03 = Guid.NewGuid();

        //Insert  new Roles
        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = roleSuperAdmin01.ToString(), Name = UserRoleType.SuperAdmin.ToString(), ConcurrencyStamp = "1", NormalizedName = UserRoleType.SuperAdmin.ToString().ToUpperInvariant() },
            new IdentityRole { Id = roleAdmin02.ToString(), Name = UserRoleType.Admin.ToString(), ConcurrencyStamp = "1", NormalizedName = UserRoleType.Admin.ToString().ToUpperInvariant() },
            new IdentityRole { Id = roleUser03.ToString(), Name = UserRoleType.User.ToString(), ConcurrencyStamp = "1", NormalizedName = UserRoleType.User.ToString().ToUpperInvariant() }
        );

        //Insert User
        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        user.PasswordHash = passwordHasher.HashPassword(user, "password@123");
        user.NormalizedEmail = user.Email?.ToUpper();
        user.NormalizedUserName = user.UserName?.ToUpper();

        builder.Entity<User>().HasData(user);
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { UserId = GuidSuperAdmin01.ToString(), RoleId = roleSuperAdmin01.ToString() }
        );
    }

    public static void SeedGender(ModelBuilder builder)
    {
        //Insert  new Roles
        builder.Entity<Gender>().HasData(
            new Gender { Guid = Guid.NewGuid(), Id = 1, Description = "Male", CreatedBy = "Manual", CreatedDate = DateTime.Now, IsActive = true, IsDeleted = false },
            new Gender { Guid = Guid.NewGuid(), Id = 2, Description = "Female", CreatedBy = "Manual", CreatedDate = DateTime.Now, IsActive = true, IsDeleted = false },
            new Gender { Guid = Guid.NewGuid(), Id = 3, Description = "Other", CreatedBy = "Manual", CreatedDate = DateTime.Now, IsActive = true, IsDeleted = false }
        );
    }
}
