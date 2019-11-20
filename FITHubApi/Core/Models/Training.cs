namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;

    public class Training : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public TrainingType Type { get; set; }
    }
}