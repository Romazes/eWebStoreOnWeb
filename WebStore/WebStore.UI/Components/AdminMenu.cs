using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebStore.UI.Components
{
    public class AdminMenu : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<AdminMenuItem> {
                new AdminMenuItem()
                {
                    DisplayValue = "User management",
                    ActionValue = "UserManagement"

                }};

            return View(menuItems);
        }
    }

    public class AdminMenuItem
    {
        public string DisplayValue { get; set; }
        public string ActionValue { get; set; }
    }
}
