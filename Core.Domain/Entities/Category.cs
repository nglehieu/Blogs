using Core.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Entities
{
    [Table("Categories")]
    public class Category : AuditableBaseEntity
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
