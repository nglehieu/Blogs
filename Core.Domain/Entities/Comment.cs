using Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    [Table("Comments")]
    public class Comment : AuditableBaseEntity
    {
        public string postId { get; set; }
        public string content { get; set; }
    }
}
