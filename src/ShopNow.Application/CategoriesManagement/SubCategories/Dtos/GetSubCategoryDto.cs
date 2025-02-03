using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNow.CategoriesManagement.SubCategories.Dtos
{
    [AutoMapFrom(typeof(SubCategory))]
    public class GetSubCategoryDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
