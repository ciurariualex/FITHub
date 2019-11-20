namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;

    public class Skill : BaseEntity<Guid>
    {
        public DateTime Experience { get; set; }
        public string Name { get; set; }
        public SkillLevel Level { get; set; }
    }
}
