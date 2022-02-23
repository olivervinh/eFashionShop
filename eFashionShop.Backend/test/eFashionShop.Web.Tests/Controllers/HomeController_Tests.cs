using System.Threading.Tasks;
using eFashionShop.Web.Controllers;
using Shouldly;
using Xunit;

namespace eFashionShop.Web.Tests.Controllers
{
    public class HomeController_Tests: eFashionShopWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
