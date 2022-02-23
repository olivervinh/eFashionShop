using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using eFashionShop.Web.Startup;
namespace eFashionShop.Web.Tests
{
    [DependsOn(
        typeof(eFashionShopWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class eFashionShopWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eFashionShopWebTestModule).GetAssembly());
        }
    }
}