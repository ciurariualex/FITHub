using Core.Data.Entities.Base;
using Core.Data.Enums;
using System;
using System.Collections.Generic;

namespace Core.Data.Entities
{
    public class Workout : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Target Target { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = new List<WorkoutExercise>();
        public ICollection<TrainingWorkout> TrainingWorkouts { get; set; } = new List<TrainingWorkout>();

    }
}