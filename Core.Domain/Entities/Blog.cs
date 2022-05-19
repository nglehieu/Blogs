using Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    [Table("Blogs")]
    public class Blog : AuditableBaseEntity
    {
        public string title { get; set; }
        public string content { get; set; }
        public string slug { get; set; }
        public string image { get; set; }
        public string author { get; set; }
        public string categoryId { get; set; }
    }
}
