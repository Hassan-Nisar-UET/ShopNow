using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShopNow.Configuration;
using ShopNow.Web;

namespace ShopNow.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ShopNowDbContextFactory : IDesignTimeDbContextFactory<ShopNowDbContext>
    {
        public ShopNowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ShopNowDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ShopNowDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ShopNowConsts.ConnectionStringName));

            return new ShopNowDbContext(builder.Options);
        }
    }
}
