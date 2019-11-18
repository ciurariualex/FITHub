namespace Core.Configurations
{
    using Core.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    internal sealed class GymConfiguration : IEntityTypeConfiguration<Gym>
    {
        public void Configure(EntityTypeBuilder<Gym> builder)
        {
            builder.ToTable("Gyms");

            builder.HasQueryFilter(gym => !gym.IsDeleted);

            builder.HasKey(gym => gym.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(gym => gym.Name)
                .IsRequired();

            builder.Property(gym => gym.Address)
                .IsRequired();

            builder.Property(gym => gym.CreatedAt)
                .IsRequired();

            builder.Property(gym => gym.CreatedBy)
                .IsRequired();

            builder.Property(gym => gym.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}