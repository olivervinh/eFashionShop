using Microsoft.EntityFrameworkCore;

namespace eFashionShop.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<eFashionShopDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for eFashionShopDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
