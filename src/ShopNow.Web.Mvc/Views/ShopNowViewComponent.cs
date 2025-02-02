using Abp.AspNetCore.Mvc.ViewComponents;

namespace ShopNow.Web.Views
{
    public abstract class ShopNowViewComponent : AbpViewComponent
    {
        protected ShopNowViewComponent()
        {
            LocalizationSourceName = ShopNowConsts.LocalizationSourceName;
        }
    }
}
