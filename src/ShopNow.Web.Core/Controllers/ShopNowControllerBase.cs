using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ShopNow.Controllers
{
    public abstract class ShopNowControllerBase: AbpController
    {
        protected ShopNowControllerBase()
        {
            LocalizationSourceName = ShopNowConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
