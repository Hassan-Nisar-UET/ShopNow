using Abp.AutoMapper;
using ShopNow.CategoriesManagement.SubSubCatogries;

namespace ShopNow.CategoriesManagement.SubSubCategories.Dtos
{
    [AutoMapTo(typeof(SubSubCategory))]
    public class CreateSubSubCategoryDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
