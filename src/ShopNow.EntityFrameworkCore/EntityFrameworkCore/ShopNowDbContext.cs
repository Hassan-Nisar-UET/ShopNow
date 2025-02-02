using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShopNow.Authorization.Roles;
using ShopNow.Authorization.Users;
using ShopNow.MultiTenancy;
using ShopNow.ProductsManagement.Products;
using ShopNow.CategoriesManagement.Categories;
using ShopNow.CategoriesManagement.SubCategories;
using ShopNow.CategoriesManagement.SubSubCatogries;
using ShopNow.ProductsManagement.Dimentions;
using ShopNow.StoresManagement.Stores;

namespace ShopNow.EntityFrameworkCore
{
    public class ShopNowDbContext : AbpZeroDbContext<Tenant, Role, User, ShopNowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubSubCategory> SubSubCategories { get; set; }
        public DbSet<Dimention> Dimentions { get; set; }
        public DbSet<Store> Stores { get; set; }
        public ShopNowDbContext(DbContextOptions<ShopNowDbContext> options)
            : base(options)
        {
        }
    }
}
