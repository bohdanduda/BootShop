using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class ProductDetailController : Controller
    {
        public IActionResult ProductDetail(string? productId = null)
        {
            ViewBag.ProductVariant = new ProductVariant(
                1,
                "Benjamin Velcro Dark Grey",
                "Tyhle botky mají styl! Kožené barefoot tenisky vhodné na užší až normální nožku Vyrobené z kvalitní hladké kůže v kombinaci s textilem. Tenká podešev přesahuje přesprsty, aby byla botka chráněna před poškozením.",
                579,
                699,
                true,
                "Tmavě modrá",
                "Do deště, turistické",
                "Guma",
                "Chlapecké",
                "BG004-001",
                "bota1.png",
                "bota2.png");

            return View("/Views/Shop/ProductDetail.cshtml");
        }
    }
}
