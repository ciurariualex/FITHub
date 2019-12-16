using Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configurations
{
    internal sealed class TrainingWorkoutConfiguration : IEntityTypeConfiguration<TrainingWorkout>
    {
        public void Configure(EntityTypeBuilder<TrainingWorkout> builder)
        {
            builder.ToTable("TrainingWorkouts");

            builder.HasKey(trainingWorkout => new { trainingWorkout.TrainingId, trainingWorkout.WorkoutId });

            builder.HasOne(trainingWorkout => trainingWorkout.Workout)
                .WithMany(workout => workout.TrainingWorkouts)
                .HasForeignKey(trainingWorkout => trainingWorkout.WorkoutId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(trainingWorkout => trainingWorkout.Training)
                .WithMany(training => training.TrainingWorkouts)
                .HasForeignKey(trainingWorkout => trainingWorkout.TrainingId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(trainingWorkout => trainingWorkout.TrainingId)
                .IsRequired();

            builder.Property(trainingWorkout => trainingWorkout.WorkoutId)
                .IsRequired();
        }
    }
}

