using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebStore.UI.ViewModels.AdministrationViewModels.Role
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Display(Name = "Users")]
        public List<string> Users { get; set; }
    }
}
