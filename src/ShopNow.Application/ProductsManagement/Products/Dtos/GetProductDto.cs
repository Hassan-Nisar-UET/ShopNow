using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ShopNow.CategoriesManagement.Categories;
using ShopNow.CategoriesManagement.SubCategories;
using ShopNow.CategoriesManagement.SubSubCatogries;
using ShopNow.Enums;
using ShopNow.ProductsManagement.Dimentions;
using ShopNow.StoresManagement.Stores;
using System;

namespace ShopNow.ProductsManagement.Products.Dtos
{
    [AutoMapFrom(typeof(Product))]
    public class GetProductDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public Guid? DimentionId { get; set; }
        public Guid? CategoryId { get; set; }
        public Guid? SubCategoryId { get; set; }
        public Guid? SubSubCategoryId { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public Guid? StoreId { get; set; }
        public Status Status { get; set; }
    }
}
