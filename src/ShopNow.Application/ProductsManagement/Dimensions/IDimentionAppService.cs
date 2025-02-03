using Abp.Application.Services;
using ShopNow.ProductsManagement.Dimensions.Dtos;
using System;

namespace ShopNow.ProductsManagement.Dimensions
{
    public interface IDimentionAppService : IAsyncCrudAppService<GetDimentionDto, Guid, PagedDimentionResultRequestDto, CreateDimentionDto, UpdateDimentionDto>
    {
    }
}
