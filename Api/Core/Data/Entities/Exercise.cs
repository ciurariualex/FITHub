using Core.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace Core.Data.Entities
{
    public class Exercise : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Reps { get; set; }
        public DateTime Duration { get; set; }
        public ICollection<WorkoutExercise> WorkoutExercises { get; set; } = new List<WorkoutExercise>();
    }
}