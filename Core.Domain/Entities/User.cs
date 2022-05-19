using Core.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    [Table("Users")]
    public class User : IdentityUser<Guid>
    {
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string AvataUrl { get; set; }
        public string Resetpassword { get; set; }
        public string Address { get; set; }
        public DateTimeOffset Birth { get; set; }
        public int Gender { get; set; }
    }
}
