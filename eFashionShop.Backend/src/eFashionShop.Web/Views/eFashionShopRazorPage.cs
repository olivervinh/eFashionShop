using Abp.AspNetCore.Mvc.Views;

namespace eFashionShop.Web.Views
{
    public abstract class eFashionShopRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected eFashionShopRazorPage()
        {
            LocalizationSourceName = eFashionShopConsts.LocalizationSourceName;
        }
    }
}
