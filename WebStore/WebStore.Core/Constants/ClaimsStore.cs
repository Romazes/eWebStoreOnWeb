using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace WebStore.Core.Constants
{
    public static class ClaimsStore
    {
        public static List<Claim> AllClaims { get; set; } = new List<Claim>()
        {
            new Claim("Create Role", "Create Role"),
            new Claim("Edit Role","Edit Role"),
            new Claim("Delete Role","Delete Role"),

            new Claim("Create Category","Create Category"),
            new Claim("Edit Category","Edit Category"),
            new Claim("Delete Category","Delete Category")
        };
    }
}