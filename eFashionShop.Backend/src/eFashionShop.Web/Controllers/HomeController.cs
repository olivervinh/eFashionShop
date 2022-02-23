using Microsoft.AspNetCore.Mvc;

namespace eFashionShop.Web.Controllers
{
    public class HomeController : eFashionShopControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}