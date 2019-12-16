using Core.Data.Entities.Base;
using Core.Data.Enums;
using System;

namespace Core.Data.Entities
{
    public class Profile : BaseEntity<Guid>
    {
        public ProfileType Type { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}