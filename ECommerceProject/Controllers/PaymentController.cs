using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PaymentGateway()
        {
            return View();
        }
    }
}
