using Abp.AutoMapper;
using ShopNow.Enums;
using System;

namespace ShopNow.ProductsManagement.Products.Dtos
{
    [AutoMapTo(typeof(Product))]
    public class CreateProductDto
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
