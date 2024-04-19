using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductView()
        {
            return View();
        }
    }
}
