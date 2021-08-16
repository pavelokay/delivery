using Delivery.Application.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Delivery.API
{
    public class ApplicationUserClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUserModel>
    {
        public ApplicationUserClaimsPrincipalFactory(UserManager<ApplicationUserModel> userManager, IOptions<IdentityOptions> optionsAccessor) : base( userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUserModel user)
        {
            ClaimsIdentity claims = await base.GenerateClaimsAsync(user);

            return claims;
        }
    }
}
