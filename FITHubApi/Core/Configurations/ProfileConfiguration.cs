namespace Core.Configurations
{
    using Core.Models;
    using Core.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.ToTable("Profiles");

            builder.HasQueryFilter(profile => !profile.IsDeleted);

            builder.HasKey(profile => profile.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(profile => profile.Name)
                .IsRequired();

            builder.Property(profile => profile.Rating)
                .HasDefaultValue(0.0)
                .IsRequired();

            builder.Property(profile => profile.Type)
                .HasDefaultValue(ProfileType.A)
                .IsRequired();

            builder.Property(profile => profile.CreatedAt)
                .IsRequired();

            builder.Property(profile => profile.CreatedBy)
                .IsRequired();

            builder.Property(profile => profile.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}