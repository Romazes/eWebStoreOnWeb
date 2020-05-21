using Microsoft.AspNetCore.Authorization;

namespace WebStore.Core.Entities.Auth.AuthPolicies
{
    public class AgeRequirement : IAuthorizationRequirement
    {
        protected internal int Age { get; set; }

        public AgeRequirement(int age)
        {
            Age = age;
        }
    }
}