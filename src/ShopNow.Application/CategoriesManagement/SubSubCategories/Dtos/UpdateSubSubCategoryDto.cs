using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.CategoriesManagement.SubSubCatogries;
using System;

namespace ShopNow.CategoriesManagement.SubSubCategories.Dtos
{
    [AutoMapTo(typeof(SubSubCategory))]
    public class UpdateSubSubCategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
