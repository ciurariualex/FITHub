using Core.Data.Entities.Base;
using System;

namespace Core.Data.Entities
{
    public class Diet : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}