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

            #region Seed Manager users
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.MANAGERS));

            #region Seed Manager user - Junior
            var managerUserJunior = new ApplicationUser
            {
                UserName = "managerJunior00@contoso.com",
                Email = "managerJunior00@contoso.com",
                Birthdate = DateTime.Now,
                City = "Town Manager - Junior",
                Country = "Country Manager - Junior"
            };

            await userManager.CreateAsync(managerUserJunior, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(managerUserJunior, AuthorizationConstants.Roles.MANAGERS);
            await userManager.AddClaimAsync(managerUserJunior, new Claim("Edit Category", "Edit Category"));
            #endregion

            #region Seed Manager user - Senior
            var managerUserSenior = new ApplicationUser
            {
                UserName = "managerSenior00@contoso.com",
                Email = "managerSenior00@contoso.com",
                Birthdate = DateTime.Now,
                City = "Town Manager - Senior",
                Country = "Country Manager - Senior"
            };

            await userManager.CreateAsync(managerUserSenior, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(managerUserSenior, AuthorizationConstants.Roles.MANAGERS);
            await userManager.AddClaimAsync(managerUserSenior, new Claim("Create Category", "Create Category"));
            await userManager.AddClaimAsync(managerUserSenior, new Claim("Edit Category", "Edit Category"));
            await userManager.AddClaimAsync(managerUserSenior, new Claim("Delete Category", "Delete Category"));
            #endregion

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
