using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ShopNow.Authorization.Roles;
using ShopNow.Authorization.Users;
using ShopNow.MultiTenancy;

namespace ShopNow.EntityFrameworkCore
{
    public class ShopNowDbContext : AbpZeroDbContext<Tenant, Role, User, ShopNowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ShopNowDbContext(DbContextOptions<ShopNowDbContext> options)
            : base(options)
        {
        }
    }
}
