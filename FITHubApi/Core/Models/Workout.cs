namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;
    using System.Collections.Generic;

    public class Workout : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Target Target { get; set; }
        public IEnumerable<Exercise> Exercises { get; set; }
    }
}