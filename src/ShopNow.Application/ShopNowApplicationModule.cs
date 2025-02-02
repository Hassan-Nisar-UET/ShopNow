using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShopNow.Authorization;

namespace ShopNow
{
    [DependsOn(
        typeof(ShopNowCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ShopNowApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ShopNowAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ShopNowApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
