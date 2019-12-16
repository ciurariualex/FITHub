using Core.Data.Entities.Base;
using Core.Data.Enums;
using System;

namespace Core.Data.Entities
{
    public class Skill : BaseEntity<Guid>
    {
        public DateTime Experience { get; set; }
        public string Name { get; set; }
        public SkillLevel Level { get; set; }
    }
}