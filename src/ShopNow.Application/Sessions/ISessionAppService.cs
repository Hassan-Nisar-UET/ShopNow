using System.Threading.Tasks;
using Abp.Application.Services;
using ShopNow.Sessions.Dto;

namespace ShopNow.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
