using Abp.Application.Services;
using ShopNow.CategoriesManagement.SubSubCategories.Dtos;
using System;

namespace ShopNow.CategoriesManagement.SubSubCategories
{
    public interface ISubSubCategoryAppService : IAsyncCrudAppService<GetSubSubCategoryDto, Guid, PagedSubSubCategoryResultRequestDto, CreateSubSubCategoryDto, UpdateSubSubCategoryDto>
    {
    }
}
