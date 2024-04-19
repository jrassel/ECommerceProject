using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WishList()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
