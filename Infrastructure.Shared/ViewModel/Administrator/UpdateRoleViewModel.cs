using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Shared.ViewModel.Administrator
{
    public class UpdateRoleViewModel
    {
        public UpdateRoleViewModel()
        {
            Users = new List<string>();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        public string RoleName { get; set; }
        public string Description { get; set; }

        public List<string> Users { get; set; }
    }
}

