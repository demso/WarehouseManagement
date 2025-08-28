using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagement.Domain;

namespace WarehouseManagement.Persistence.EntityTypeConfigurations;

public class ResourceConfiguration : IEntityTypeConfiguration<WarehouseResource> {
    public void Configure(EntityTypeBuilder<WarehouseResource> builder) {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();
        builder.HasIndex(x => x.Name)
            .IsUnique();
        builder.Property(x => x.State)
            .HasConversion<string>();
    }
}
