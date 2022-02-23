using eFashionShop.EntityFrameworkCore;

namespace eFashionShop.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly eFashionShopDbContext _context;

        public TestDataBuilder(eFashionShopDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}