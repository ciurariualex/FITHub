namespace Core.Configurations
{
    using Core.Models;
    using Core.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    internal sealed class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skills");

            builder.HasQueryFilter(skill => !skill.IsDeleted);

            builder.HasKey(skill => skill.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(skill => skill.Name)
                .IsRequired();

            builder.Property(skill => skill.Experience)
                .HasDefaultValue(new DateTime(0, 0, 0))
                .IsRequired();

            builder.Property(skill => skill.Level)
                .HasDefaultValue(SkillLevel.Beginner)
                .IsRequired();

            builder.Property(skill => skill.CreatedAt)
                .IsRequired();

            builder.Property(skill => skill.CreatedBy)
                .IsRequired();

            builder.Property(skill => skill.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}