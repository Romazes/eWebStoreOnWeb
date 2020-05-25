using System.ComponentModel.DataAnnotations;

namespace WebStore.UI.ViewModels.AdministrationViewModels.Role
{
    public class AddRoleViewModel
    {
        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }
    }
}
