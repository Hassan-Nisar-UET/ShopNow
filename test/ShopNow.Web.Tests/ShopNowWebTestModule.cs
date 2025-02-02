using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShopNow.EntityFrameworkCore;
using ShopNow.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ShopNow.Web.Tests
{
    [DependsOn(
        typeof(ShopNowWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ShopNowWebTestModule : AbpModule
    {
        public ShopNowWebTestModule(ShopNowEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ShopNowWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ShopNowWebMvcModule).Assembly);
        }
    }
}