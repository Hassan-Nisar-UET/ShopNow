using Abp.Application.Services;
using ShopNow.CategoriesManagement.Categories.Dtos;
using System;

namespace ShopNow.CategoriesManagement.Categories
{
    public interface ICategoryAppService : IAsyncCrudAppService<GetCategoryDto, Guid, PagedCategoryResultRequestDto, CreateCategoryDto, UpdateCategoryDto>
    {
    }
}
