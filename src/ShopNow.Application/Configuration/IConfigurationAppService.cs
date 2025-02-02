using System.Threading.Tasks;
using ShopNow.Configuration.Dto;

namespace ShopNow.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
