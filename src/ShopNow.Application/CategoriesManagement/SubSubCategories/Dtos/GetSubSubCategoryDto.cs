using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.CategoriesManagement.SubSubCatogries;
using System;

namespace ShopNow.CategoriesManagement.SubSubCategories.Dtos
{
    [AutoMapFrom(typeof(SubSubCategory))]
    public class GetSubSubCategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
