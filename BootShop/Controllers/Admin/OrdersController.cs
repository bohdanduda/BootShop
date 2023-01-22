using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Admin/Orders.cshtml");
        }
    }
}
