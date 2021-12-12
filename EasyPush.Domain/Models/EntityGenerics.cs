using System;
using System.Collections.Generic;
using System.Text;

namespace EasyPush.Domain.Models
{
    public class EntityGenerics
    {
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; }
    }
}
