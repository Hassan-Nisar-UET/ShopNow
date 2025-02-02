using Abp.Application.Services;
using ShopNow.MultiTenancy.Dto;

namespace ShopNow.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

