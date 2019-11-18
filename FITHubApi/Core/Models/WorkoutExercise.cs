namespace Core.Models
{
    using System;
    public class WorkoutExercise
    {
        public Guid WorkoutId { get; set; }
        public Guid ExerciseId { get; set; }

        public virtual Workout Workout { get; set; }
        public virtual Exercise Exercise { get; set; }
    }
}
