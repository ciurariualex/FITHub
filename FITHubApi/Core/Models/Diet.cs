namespace Core.Models
{
    using Core.Models.Base;
    using Core.Models.Enums;
    using System;
    using System.Collections.Generic;

    public class Diet : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}