using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eFashionShop.Configuration;
using eFashionShop.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace eFashionShop.Web.Startup
{
    [DependsOn(
        typeof(eFashionShopApplicationModule), 
        typeof(eFashionShopEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class eFashionShopWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public eFashionShopWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(eFashionShopConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<eFashionShopNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(eFashionShopApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eFashionShopWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(eFashionShopWebModule).Assembly);
        }
    }
}
