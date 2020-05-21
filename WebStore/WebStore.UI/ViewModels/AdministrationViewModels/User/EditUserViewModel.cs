using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebStore.UI.ViewModels.AdministrationViewModels.User
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Roles = new List<string>();
            Claims = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter the user name")]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter the user email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the birth date")]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        [Display(Name = "Roles")]
        public List<string> Roles { get; set; }

        [Display(Name = "Claims")]
        public List<string> Claims { get; set; }
    }
}