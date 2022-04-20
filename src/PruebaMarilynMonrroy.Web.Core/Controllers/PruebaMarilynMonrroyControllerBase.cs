using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PruebaMarilynMonrroy.Controllers
{
    public abstract class PruebaMarilynMonrroyControllerBase: AbpController
    {
        protected PruebaMarilynMonrroyControllerBase()
        {
            LocalizationSourceName = PruebaMarilynMonrroyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
