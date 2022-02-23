using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eFashionShop.EntityFrameworkCore
{
    public class eFashionShopDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public eFashionShopDbContext(DbContextOptions<eFashionShopDbContext> options) 
            : base(options)
        {

        }
    }
}
