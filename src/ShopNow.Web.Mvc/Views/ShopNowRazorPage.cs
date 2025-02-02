using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ShopNow.Web.Views
{
    public abstract class ShopNowRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ShopNowRazorPage()
        {
            LocalizationSourceName = ShopNowConsts.LocalizationSourceName;
        }
    }
}
