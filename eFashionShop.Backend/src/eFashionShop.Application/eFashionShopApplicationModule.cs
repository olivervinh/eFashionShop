using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace eFashionShop
{
    [DependsOn(
        typeof(eFashionShopCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class eFashionShopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eFashionShopApplicationModule).GetAssembly());
        }
    }
}