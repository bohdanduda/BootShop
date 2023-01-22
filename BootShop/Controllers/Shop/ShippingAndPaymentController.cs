using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class ShippingAndPaymentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.contact = this.HttpContext.Session.GetString("customerContact");
            ViewBag.address = this.HttpContext.Session.GetString("customerAddress");

            return View("/Views/Shop/ShippingAndPayment.cshtml");
        }
    }
}
