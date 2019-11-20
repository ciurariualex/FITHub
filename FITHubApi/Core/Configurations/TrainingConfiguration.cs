namespace Core.Configurations
{
    using Core.Models;
    using Core.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using System;

    internal sealed class TrainingConfiguration : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.ToTable("Trainings");

            builder.HasQueryFilter(training => !training.IsDeleted);

            builder.HasKey(training => training.Id)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.Property(training => training.Name)
                .IsRequired();

            builder.Property(training => training.Type)
                .HasDefaultValue(TrainingType.Cardio)
                .IsRequired();

            builder.Property(training => training.CreatedAt)
                .IsRequired();

            builder.Property(training => training.CreatedBy)
                .IsRequired();

            builder.Property(training => training.IsDeleted)
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}