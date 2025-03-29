namespace CleanApp.Domain.DTO;

public class EmployeeDTO
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string postalCode { get; set; } = null!;

    public string Country { get; set; } = null!;
}
