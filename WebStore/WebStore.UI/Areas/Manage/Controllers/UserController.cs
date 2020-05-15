using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebStore.Core.Constants;
using WebStore.Core.Entities.Auth;
using WebStore.UI.ViewModels.AdministrationViewModels.User;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore.UI.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = AuthorizationConstants.Roles.ADMINISTRATORS)]
    public class UserController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var users = _userManager.Users;
            return View(users);
        }

        public async Task<IActionResult> EditUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
                return RedirectToAction("UserManagement", _userManager.Users);

            var vm = new EditUserViewModel() { Id = user.Id, Email = user.Email, UserName = user.UserName, Birthdate = user.Birthdate, City = user.City, Country = user.Country };

            return View(vm);
        }
    }
}
