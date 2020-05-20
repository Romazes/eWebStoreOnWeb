using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace WebStore.Core.Constants
{
    public class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Create Role", "Create Role"),
            new Claim("Edit Role","Edit Role"),
            new Claim("Delete Role","Delete Role")
        };
    }
}
