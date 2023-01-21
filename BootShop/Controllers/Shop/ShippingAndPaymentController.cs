using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class ShippingAndPaymentController : Controller
    {
        public IActionResult Index()
        {
            return View("/Views/Shop/ShippingAndPayment.cshtml");
        }
    }
}
