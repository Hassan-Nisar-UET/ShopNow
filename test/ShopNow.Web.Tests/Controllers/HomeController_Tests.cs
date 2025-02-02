using System.Threading.Tasks;
using ShopNow.Models.TokenAuth;
using ShopNow.Web.Controllers;
using Shouldly;
using Xunit;

namespace ShopNow.Web.Tests.Controllers
{
    public class HomeController_Tests: ShopNowWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}