using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Shop
{
    public class ProductDetailController : Controller
    {
        private BootShopContext context = new BootShopContext();

        public IActionResult ProductDetail(Product_Variant productVariant)
        {
            ViewBag.ProductVariant = this.context.ProductVariants
                .Include(v => v.Product)
                .Include(v => v.Color)
                .Include(v => v.Product.Brand)
                .Include(v => v.Product.Category)
                .Include(v => v.Product.Subcategory)
                .FirstOrDefault(v => v.Id == productVariant.Id);

            return View("/Views/Shop/ProductDetail.cshtml");
        }
    }
}
