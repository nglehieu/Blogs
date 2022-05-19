using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Shared.ViewModel
{
    public class LoginResponseDto
    {
        public Guid Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public short Gender { get; set; }
        public string Address { get; set; }
        public string UrlImage { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
