namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;

    public class Package : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public PackageType Type { get; set; }
    }
}