using Abp.Modules;
using Abp.Reflection.Extensions;
using eFashionShop.Localization;

namespace eFashionShop
{
    public class eFashionShopCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            eFashionShopLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = eFashionShopConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(eFashionShopCoreModule).GetAssembly());
        }
    }
}