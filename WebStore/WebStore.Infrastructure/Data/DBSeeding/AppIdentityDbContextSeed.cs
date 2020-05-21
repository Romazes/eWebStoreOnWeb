using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using WebStore.Core.Constants;
using WebStore.Core.Entities.Auth;

namespace WebStore.Infrastructure.Data.DBSeeding
{
    public static class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            #region Seed Admin user
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.ADMINISTRATORS));

            var adminUser = new ApplicationUser
            {
                UserName = "admin00@contoso.com",
                Email = "admin00@contoso.com",
                Birthdate = DateTime.Now,
                City = "Town Admin",
                Country = "Country Admin"
            };

            await userManager.CreateAsync(adminUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(adminUser, AuthorizationConstants.Roles.ADMINISTRATORS);
            await userManager.AddClaimAsync(adminUser, new Claim("Create Role", "Create Role"));
            await userManager.AddClaimAsync(adminUser, new Claim("Edit Role","Edit Role"));
            await userManager.AddClaimAsync(adminUser, new Claim("Delete Role","Delete Role"));
            await userManager.AddClaimAsync(adminUser, new Claim("Create Category","Create Category"));
            await userManager.AddClaimAsync(adminUser, new Claim("Edit Category","Edit Category"));
            await userManager.AddClaimAsync(adminUser, new Claim("Delete Category", "Delete Category"));
            #endregion

            #region Seed Manager user
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.MANAGERS));

            var managerUser = new ApplicationUser
            {
                UserName = "manager00@contoso.com",
                Email = "manager00@contoso.com",
                Birthdate = DateTime.Now,
                City = "Town Manager",
                Country = "Country Manager"
            };

            await userManager.CreateAsync(managerUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(managerUser, AuthorizationConstants.Roles.MANAGERS);
            await userManager.AddClaimAsync(managerUser, new Claim("Edit Category", "Edit Category"));
            //await userManager.AddClaimAsync(managerUser, new Claim("Delete Category", "Delete Category"));
            #endregion

            #region Seed default user
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.USERS));

            var defaultUser = new ApplicationUser
            {
                UserName = "user00@contoso.com",
                Email = "user00@contoso.com",
                Birthdate = DateTime.Now,
                City = "Town User",
                Country = "Country User"
            };

            await userManager.CreateAsync(defaultUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(defaultUser, AuthorizationConstants.Roles.USERS);
            #endregion
        }
    }
}
