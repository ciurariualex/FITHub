namespace Core.Configurations
{
    using Core.Models;
    using Core.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal sealed class PackageConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.ToTable("Packages");

            builder.HasQueryFilter(package => !package.IsDeleted);

            builder.HasKey(package => package.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(package => package.Name)
                .IsRequired();

            builder.Property(package => package.Type)
                .HasDefaultValue(PackageType.A)
                .IsRequired();

            builder.Property(package => package.CreatedAt)
                .IsRequired();

            builder.Property(package => package.CreatedBy)
                .IsRequired();

            builder.Property(package => package.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}