namespace Core.Configurations
{
    using Core.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal sealed class DietConfiguration : IEntityTypeConfiguration<Diet>
    {
        public void Configure(EntityTypeBuilder<Diet> builder)
        {
            builder.ToTable("Diets");

            builder.HasQueryFilter(diet => !diet.IsDeleted);

            builder.HasKey(diet => diet.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(diet => diet.Name)
                .IsRequired();

            builder.Property(diet => diet.CreatedAt)
                .IsRequired();

            builder.Property(diet => diet.CreatedBy)
                .IsRequired();

            builder.Property(diet => diet.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}