using Abp.Application.Services;
using ShopNow.CategoriesManagement.SubCategories.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.CategoriesManagement.SubCategories
{
    public interface ISubCategoryAppService : IAsyncCrudAppService<GetSubCategoryDto, Guid, PagedSubCategoryResultRequestDto, CreateSubCategoryDto, UpdateSubCategoryDto>
    {
    }
}
