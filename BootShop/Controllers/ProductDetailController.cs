using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult ProductDetail(string? productId=null)
        {
            ViewBag.ProductId = productId;
            return View();
        }
    }
}
