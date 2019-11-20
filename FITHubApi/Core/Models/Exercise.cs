namespace Core.Models
{
    using Core.Models.Base;
    using System;

    public class Exercise : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public int Reps { get; set; }
        public DateTime Duration { get; set; }
    }
}