using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class OrderCompleteController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Shop/OrderComplete.cshtml");
        }
    }
}
