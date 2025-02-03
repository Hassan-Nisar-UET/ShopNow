using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ShopNow.CategoriesManagement.SubSubCategories.Dtos;
using ShopNow.CategoriesManagement.SubSubCatogries;
using System;
using System.Threading.Tasks;

namespace ShopNow.CategoriesManagement.SubSubCategories
{
    public class SubSubCategoryAppService : AsyncCrudAppService<SubSubCategory, GetSubSubCategoryDto, Guid, PagedSubSubCategoryResultRequestDto, CreateSubSubCategoryDto, UpdateSubSubCategoryDto>, ISubSubCategoryAppService
    {
        public SubSubCategoryAppService(IRepository<SubSubCategory, Guid> repository) : base(repository)
        {
        }

        public override Task<GetSubSubCategoryDto> CreateAsync(CreateSubSubCategoryDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<Guid> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<GetSubSubCategoryDto>> GetAllAsync(PagedSubSubCategoryResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<GetSubSubCategoryDto> GetAsync(EntityDto<Guid> input)
        {
            return base.GetAsync(input);
        }

        public override Task<GetSubSubCategoryDto> UpdateAsync(UpdateSubSubCategoryDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<SubSubCategory> GetEntityByIdAsync(Guid id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
