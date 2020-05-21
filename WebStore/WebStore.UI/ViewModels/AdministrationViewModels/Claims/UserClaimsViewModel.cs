using System.Collections.Generic;
using WebStore.Core.Entities.Auth;

namespace WebStore.UI.ViewModels.AdministrationViewModels.Claims
{
    public class UserClaimsViewModel
    {
        public UserClaimsViewModel()
        {
            Cliams = new List<UserClaim>();
        }

        public string UserId { get; set; }
        public List<UserClaim> Cliams { get; set; }
    }
}
