using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers
{
    public class ProductDetailController : Controller
    {
        public IActionResult ProductDetail(string? productId=null)
        {
            ViewBag.ProductVariant = new ProductVariant();

            return View();
        }
    }
}
