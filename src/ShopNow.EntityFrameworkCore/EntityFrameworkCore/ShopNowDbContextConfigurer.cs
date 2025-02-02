using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ShopNow.EntityFrameworkCore
{
    public static class ShopNowDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ShopNowDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ShopNowDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
