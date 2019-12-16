using Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core.Data.Configurations
{
    internal sealed class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            builder.ToTable("WorkoutExercises");

            builder.HasOne(workoutExercise => workoutExercise.Workout)
               .WithMany(workout => workout.WorkoutExercises)
               .HasForeignKey(workoutExercise => workoutExercise.WorkoutId)
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(workoutExercise => workoutExercise.Exercise)
                .WithMany(exercise => exercise.WorkoutExercises)
                .HasForeignKey(workoutExercise => workoutExercise.ExerciseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(workoutExercise => new { workoutExercise.WorkoutId, workoutExercise.ExerciseId });

            builder.Property(workoutExercise => workoutExercise.WorkoutId)
                .IsRequired();

            builder.Property(workoutExercise => workoutExercise.Exercise)
                .IsRequired();
        }
    }
}

