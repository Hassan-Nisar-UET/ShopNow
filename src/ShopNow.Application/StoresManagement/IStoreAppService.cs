using Abp.Application.Services;
using ShopNow.StoresManagement.Dtos;
using System;

namespace ShopNow.StoresManagement
{
    internal interface IStoreAppService : IAsyncCrudAppService<GetStoreDto,Guid,PagedStoreResultRequestDto,CreateStoreDto,UpdateStoreDto>
    {
    }
}
