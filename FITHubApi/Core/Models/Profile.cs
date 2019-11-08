namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;

    public class Profile : BaseEntity<Guid>
    {
        public ProfileType Type { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
    }
}