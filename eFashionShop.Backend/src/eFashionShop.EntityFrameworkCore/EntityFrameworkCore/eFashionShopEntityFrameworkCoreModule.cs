using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace eFashionShop.EntityFrameworkCore
{
    [DependsOn(
        typeof(eFashionShopCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class eFashionShopEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eFashionShopEntityFrameworkCoreModule).GetAssembly());
        }
    }
}