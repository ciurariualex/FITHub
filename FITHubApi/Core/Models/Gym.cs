namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Other;
    using System;

    public class Gym : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}