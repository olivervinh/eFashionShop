using System;
using System.Threading.Tasks;
using Abp.TestBase;
using eFashionShop.EntityFrameworkCore;
using eFashionShop.Tests.TestDatas;

namespace eFashionShop.Tests
{
    public class eFashionShopTestBase : AbpIntegratedTestBase<eFashionShopTestModule>
    {
        public eFashionShopTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<eFashionShopDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<eFashionShopDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<eFashionShopDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<eFashionShopDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<eFashionShopDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<eFashionShopDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<eFashionShopDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<eFashionShopDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
