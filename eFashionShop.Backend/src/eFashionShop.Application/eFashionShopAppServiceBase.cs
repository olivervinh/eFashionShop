using Abp.Application.Services;

namespace eFashionShop
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class eFashionShopAppServiceBase : ApplicationService
    {
        protected eFashionShopAppServiceBase()
        {
            LocalizationSourceName = eFashionShopConsts.LocalizationSourceName;
        }
    }
}