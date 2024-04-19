using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShopGrid()
        {
            return View();
        }
    }
}
