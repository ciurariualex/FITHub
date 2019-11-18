namespace Core.Configurations
{
    using Core.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class TrainingWorkoutConfiguration : IEntityTypeConfiguration<TrainingWorkout>
    {
        public void Configure(EntityTypeBuilder<TrainingWorkout> builder)
        {
            builder.ToTable("TrainingWorkout");

            builder.HasOne(trainingWorkout => trainingWorkout.Training);

            builder.HasOne(trainingWorkout => trainingWorkout.Workout);

            builder.HasKey(trainingWorkout => new { trainingWorkout.TrainingId, trainingWorkout.WorkoutId });

            builder.Property(trainingWorkout => trainingWorkout.TrainingId)
                .IsRequired();

            builder.Property(trainingWorkout => trainingWorkout.WorkoutId)
                .IsRequired();
        }
    }
}