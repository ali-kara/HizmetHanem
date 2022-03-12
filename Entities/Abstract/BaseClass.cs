using Core.Entities;
using System;

namespace Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateModified { get; set; }
        public string LastUser { get; set; }
        public bool? IsDeleted { get; set; } = false;

    }
}
