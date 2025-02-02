using Abp.Domain.Entities.Auditing;
using ShopNow.CategoriesManagement.Categories;
using ShopNow.CategoriesManagement.SubCategories;
using ShopNow.CategoriesManagement.SubSubCatogries;
using ShopNow.Enums;
using ShopNow.ProductsManagement.Dimentions;
using ShopNow.StoresManagement.Stores;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopNow.ProductsManagement.Products
{
    [Table("ProductsTbl", Schema = "product")]
    public class Product : FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Weight { get; set; }
        public Dimention Dimention { get; set; }
        public Guid? DimentionId { get; set; }
        public Category Category { get; set; }
        public Guid? CategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public Guid? SubCategoryId { get; set; }         
        public SubSubCategory SubSubCategory { get; set; }
        public Guid? SubSubCategoryId { get; set; } 
        public string Description { get; set; }
        public string Price { get; set; }    
        public Store Store { get; set; }
        public Guid? StoreId { get; set; }
        public Status Status { get; set; }
    }

}
