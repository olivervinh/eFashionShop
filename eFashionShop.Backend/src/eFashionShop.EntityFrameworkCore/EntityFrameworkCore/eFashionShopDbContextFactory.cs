using eFashionShop.Configuration;
using eFashionShop.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eFashionShop.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class eFashionShopDbContextFactory : IDesignTimeDbContextFactory<eFashionShopDbContext>
    {
        public eFashionShopDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<eFashionShopDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(eFashionShopConsts.ConnectionStringName)
            );

            return new eFashionShopDbContext(builder.Options);
        }
    }
}