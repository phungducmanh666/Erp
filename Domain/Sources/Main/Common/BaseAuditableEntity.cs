using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Sources.Main.Common
{
    public abstract class BaseAuditableEntity<TId> : BaseEntity<TId>
    {
        public DateTime CreatedAt { get; set; }
        public string? CreatedBy { get; set; } // Có thể là UserId hoặc Username
        public DateTime? LastModifiedAt { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}
