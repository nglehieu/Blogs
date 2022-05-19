using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Domain.Common
{
    public class AuditableBaseEntity
    {
        [Key]
        public virtual string uuid { get; set; }

        public bool? status { get; set; }
        public DateTime? createdDate { get; set; }
        public double? modifieldDate { get; set; }
    }
}
