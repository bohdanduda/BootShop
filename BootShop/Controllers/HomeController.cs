using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
