using System;

namespace Infrastructure.Shared.ViewModel.Administrator
{
    public class UserRoleViewModel
    {
        public Guid roleId { get; set; }
        public string roleName { get; set; }
        public bool isSelected { get; set; }
    }
}
