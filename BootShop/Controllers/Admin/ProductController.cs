using Microsoft.AspNetCore.Mvc;
using BootShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class ProductController : Controller
    {
        private BootShopContext context = new BootShopContext();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Products = this.context.Products.Include(p=>p.Brand).Include(p=>p.Category).Include(p=>p.Subcategory);
            ViewBag.Brands = this.context.Brands;
            ViewBag.Categories = this.context.Categories;
            ViewBag.Subcategories = this.context.Subcategories;

            return View("Views/Admin/Product.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Product product)
        {
            this.context.Products.Add(product);
            this.context.SaveChanges();

            ViewBag.Products = this.context.Products;
            ViewBag.Brands = this.context.Brands;
            ViewBag.Categories = this.context.Categories;
            ViewBag.Subcategories = this.context.Subcategories;

            return View("Views/Admin/Product.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Product product)
        {
            this.context.Products.Remove(product);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Product product)
        {
            ViewBag.Product = this.context.Products.Find(product.Id);
            ViewBag.Brands = this.context.Brands;
            ViewBag.Categories = this.context.Categories;
            ViewBag.Subcategories = this.context.Subcategories;

            return View("/Views/Admin/ProductEdit.cshtml");
        }
        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(Product product)
        {
            this.context.Products.Update(product);
            this.context.SaveChanges();

            ViewBag.Product = this.context.Products.Find(product.Id);
            ViewBag.Brands = this.context.Brands;
            ViewBag.Categories = this.context.Categories;
            ViewBag.Subcategories = this.context.Subcategories;

            return View("/Views/Admin/ProductEdit.cshtml");
        }
    }
}
