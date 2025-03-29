using CleanApp.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanApp.Presentation.Configurations;

public class GenderConfiguration: IEntityTypeConfiguration<Gender>
{
    public void Configure(EntityTypeBuilder<Gender> builder)
    {
        builder.HasKey(k => new { k.Id });
        builder.Property(k => k.Guid).ValueGeneratedOnAdd();
        builder.Property(k => k.Id).ValueGeneratedOnAdd();
        builder.Property(k => k.IsActive).HasDefaultValue(true);
        builder.Property(k => k.IsDeleted).HasDefaultValue(false);
        builder.Property(k => k.CreatedDate).HasDefaultValue(DateTime.UtcNow);
    }
}

