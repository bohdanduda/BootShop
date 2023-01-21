using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class CustomerInfoController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Shop/CustomerInfo.cshtml");
        }
    }
}
