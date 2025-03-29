namespace CleanApp.Domain.Entity;

public class Gender : BaseEntity
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
