using Microsoft.AspNetCore.Identity;
namespace CleanApp.Domain.Entity;

public class User : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set; }
    public bool IsDelete { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime CreatedDate { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime UpdatedDate { get; set; }

}
