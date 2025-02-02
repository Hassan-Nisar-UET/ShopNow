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

        // Dimention relationship
        public Dimention Dimention { get; set; }
        public Guid? DimentionId { get; set; }

        // Category relationship
        public Category Category { get; set; }
        public Guid? CategoryId { get; set; }

        // SubCategory relationship (note the property name change)
        public SubCategory SubCategory { get; set; }
        public Guid? SubCategoryId { get; set; } // Renamed from "SubCatId" to "SubCategoryId"

        // SubSubCategory relationship (note the property name change)
        public SubSubCategory SubSubCategory { get; set; }
        public Guid? SubSubCategoryId { get; set; } // Renamed from "SubSubCatId" to "SubSubCategoryId"

        public string Description { get; set; }
        public string Price { get; set; }

        // Store relationship
        public Store Store { get; set; }
        public Guid? StoreId { get; set; }

        public Status Status { get; set; }
    }

}
