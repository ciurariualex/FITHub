using Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configurations
{
    internal sealed class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.ToTable("Exercises");

            builder.HasQueryFilter(exerice => !exerice.IsDeleted);

            builder.HasKey(exericse => exericse.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(exericse => exericse.Name)
                .IsRequired();

            builder.Property(exericse => exericse.CreatedAt)
                .IsRequired();

            builder.Property(exericse => exericse.CreatedBy)
                .IsRequired();

            builder.Property(exericse => exericse.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}

