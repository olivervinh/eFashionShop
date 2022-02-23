using Abp.AspNetCore.Mvc.Controllers;

namespace eFashionShop.Web.Controllers
{
    public abstract class eFashionShopControllerBase: AbpController
    {
        protected eFashionShopControllerBase()
        {
            LocalizationSourceName = eFashionShopConsts.LocalizationSourceName;
        }
    }
}