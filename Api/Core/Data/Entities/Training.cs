using Core.Data.Entities.Base;
using Core.Data.Enums;
using System;
using System.Collections.Generic;

namespace Core.Data.Entities
{
    public class Training : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public TrainingType Type { get; set; }
        public ICollection<TrainingWorkout> TrainingWorkouts { get; set; } = new List<TrainingWorkout>();
    }
}