using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ElsaProject.Controllers
{
    public abstract class ElsaProjectControllerBase: AbpController
    {
        protected ElsaProjectControllerBase()
        {
            LocalizationSourceName = ElsaProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
