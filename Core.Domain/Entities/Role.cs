using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Domain.Entities
{
    [Table("Roles")]
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
