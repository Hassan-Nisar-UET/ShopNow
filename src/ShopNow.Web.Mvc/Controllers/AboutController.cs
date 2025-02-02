using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ShopNow.Controllers;

namespace ShopNow.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ShopNowControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
