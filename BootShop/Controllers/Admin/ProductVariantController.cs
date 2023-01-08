using Microsoft.AspNetCore.Mvc;
using BootShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class ProductVariantController : Controller
    {
        private BootShopContext context = new BootShopContext();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Include(v => v.Color);
            ViewBag.Products = this.context.Products;
            ViewBag.Colors = this.context.Colors;
            ViewBag.Sizes = this.context.Sizes;

            return View("Views/Admin/ProductVariant.cshtml");
        }

        [HttpPost]
        public IActionResult Index(ProductVariant productVariant)
        {
            this.context.ProductVariants.Add(productVariant);
            this.context.SaveChanges();

            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Include(v => v.Color);
            ViewBag.Products = this.context.Products;
            ViewBag.Colors = this.context.Colors;
            ViewBag.Sizes = this.context.Sizes;

            return View("Views/Admin/ProductVariant.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(ProductVariant productVariant)
        {
            this.context.ProductVariants.Remove(productVariant);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(ProductVariant productVariant)
        {
            ViewBag.ProductVariant = this.context.ProductVariants.Find(productVariant.Id);
            ViewBag.Products = this.context.Products;
            ViewBag.Colors = this.context.Colors;
            ViewBag.Sizes = this.context.Sizes;

            return View("/Views/Admin/ProductVariantEdit.cshtml");
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(ProductVariant productVariant)
        {
            this.context.ProductVariants.Update(productVariant);
            this.context.SaveChanges();

            ViewBag.ProductVariant = this.context.ProductVariants.Find(productVariant.Id);
            ViewBag.Products = this.context.Products;
            ViewBag.Colors = this.context.Colors;
            ViewBag.Sizes = this.context.Sizes;

            return View("/Views/Admin/ProductVariantEdit.cshtml");
        }
    }
}
