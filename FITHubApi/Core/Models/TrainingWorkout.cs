namespace Core.Models
{
    using System;
    public class TrainingWorkout
    {
        public Guid TrainingId { get; set; }
        public Guid WorkoutId { get; set; }

        public virtual Training Training { get; set; }
        public virtual Workout Workout { get; set; }
    }
}
