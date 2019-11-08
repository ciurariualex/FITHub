namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;
    using System.Collections.Generic;

    public class Training : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public TrainingType Type { get; set; }
        public IEnumerable<Workout> Workouts { get; set; }
    }
}