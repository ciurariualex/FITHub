namespace Core.Configurations
{
    using Core.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    internal sealed class WorkoutExerciseConfiguration : IEntityTypeConfiguration<WorkoutExercise>
    {
        public void Configure(EntityTypeBuilder<WorkoutExercise> builder)
        {
            builder.ToTable("WorkoutExercises");

            builder.HasOne(workoutExercise => workoutExercise.Workout);

            builder.HasOne(workoutExercise => workoutExercise.Exercise);

            builder.HasKey(workoutExercise => new { workoutExercise.WorkoutId, workoutExercise.ExerciseId });

            builder.Property(workoutExercise => workoutExercise.WorkoutId)
                .IsRequired();

            builder.Property(workoutExercise => workoutExercise.Exercise)
                .IsRequired();
        }
    }
}