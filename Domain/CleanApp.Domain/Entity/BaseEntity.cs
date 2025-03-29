namespace CleanApp.Domain.Entity;

public class BaseEntity
{
    public Guid Guid { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

}
