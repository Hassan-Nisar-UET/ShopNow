using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ShopNow.Configuration.Dto;

namespace ShopNow.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ShopNowAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
