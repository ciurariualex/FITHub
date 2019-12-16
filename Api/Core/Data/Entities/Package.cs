using Core.Data.Entities.Base;
using Core.Data.Enums;
using System;

namespace Core.Data.Entities
{
    public class Package : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public PackageType Type { get; set; }
    }
}