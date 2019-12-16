using Core.Data.Entities.Base;
using System;

namespace Core.Data.Entities
{
    public class Gym : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}