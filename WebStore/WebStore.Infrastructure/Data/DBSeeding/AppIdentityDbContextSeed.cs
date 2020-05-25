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
            DateTime dateOfBirthAdult = new DateTime(DateTime.Today.Year - AuthorizationConstants.Policies.MINIMUM_ORDER_AGE - 2, DateTime.Today.Month, DateTime.Today.Day);
            DateTime dateOfBirthChild = new DateTime(DateTime.Today.Year - AuthorizationConstants.Policies.MINIMUM_ORDER_AGE + 2, DateTime.Today.Month, DateTime.Today.Day);

            #region Seed Admin user
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.ADMINISTRATORS));

            var adminUser = new ApplicationUser
            {
                UserName = "admin00@contoso.com",
                Email = "admin00@contoso.com",
                Birthdate = dateOfBirthAdult,
                City = "Town Admin",
                Country = "Country Admin"
            };

            await userManager.CreateAsync(adminUser, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(adminUser, AuthorizationConstants.Roles.ADMINISTRATORS);

            await userManager.AddClaimAsync(adminUser, new Claim(ClaimTypes.DateOfBirth, adminUser.Birthdate.Year.ToString()));

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
                Birthdate = dateOfBirthAdult,
                City = "Town Manager - Junior",
                Country = "Country Manager - Junior"
            };

            await userManager.CreateAsync(managerUserJunior, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(managerUserJunior, AuthorizationConstants.Roles.MANAGERS);

            await userManager.AddClaimAsync(managerUserJunior, new Claim(ClaimTypes.DateOfBirth, managerUserJunior.Birthdate.Year.ToString()));

            await userManager.AddClaimAsync(managerUserJunior, new Claim("Edit Category", "Edit Category"));
            #endregion

            #region Seed Manager user - Senior
            var managerUserSenior = new ApplicationUser
            {
                UserName = "managerSenior00@contoso.com",
                Email = "managerSenior00@contoso.com",
                Birthdate = dateOfBirthAdult,
                City = "Town Manager - Senior",
                Country = "Country Manager - Senior"
            };

            await userManager.CreateAsync(managerUserSenior, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(managerUserSenior, AuthorizationConstants.Roles.MANAGERS);

            await userManager.AddClaimAsync(managerUserSenior, new Claim(ClaimTypes.DateOfBirth, managerUserSenior.Birthdate.Year.ToString()));

            await userManager.AddClaimAsync(managerUserSenior, new Claim("Create Category", "Create Category"));
            await userManager.AddClaimAsync(managerUserSenior, new Claim("Edit Category", "Edit Category"));
            await userManager.AddClaimAsync(managerUserSenior, new Claim("Delete Category", "Delete Category"));
            #endregion

            #endregion

            #region Seed default users
            await roleManager.CreateAsync(new IdentityRole(AuthorizationConstants.Roles.USERS));

            #region Seed default user - Child
            var defaultUserChild = new ApplicationUser
            {
                UserName = "userChild00@contoso.com",
                Email = "userChild00@contoso.com",
                Birthdate = dateOfBirthChild,
                City = "Town User Child",
                Country = "Country User Child"
            };

            await userManager.CreateAsync(defaultUserChild, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(defaultUserChild, AuthorizationConstants.Roles.USERS);

            await userManager.AddClaimAsync(defaultUserChild, new Claim(ClaimTypes.DateOfBirth, defaultUserChild.Birthdate.Year.ToString()));
            #endregion

            #region Seed default user - Adult
            var defaultUserAdult = new ApplicationUser
            {
                UserName = "userAdult00@contoso.com",
                Email = "userAdult00@contoso.com",
                Birthdate = dateOfBirthAdult,
                City = "Town User Adult",
                Country = "Country User Adult"
            };

            await userManager.CreateAsync(defaultUserAdult, AuthorizationConstants.DEFAULT_PASSWORD);
            await userManager.AddToRoleAsync(defaultUserAdult, AuthorizationConstants.Roles.USERS);

            await userManager.AddClaimAsync(defaultUserAdult, new Claim(ClaimTypes.DateOfBirth, defaultUserAdult.Birthdate.Year.ToString()));
            #endregion

            #endregion
        }
    }
}
