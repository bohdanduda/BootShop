using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class SubcategoryController : Controller
    {
        private BootShopContext context = new();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Subcategories = this.context.Subcategories.Include(s => s.Category); // https://learn.microsoft.com/en-us/ef/ef6/querying/related-data 
            ViewBag.Categories = this.context.Categories;

            return View("/Views/Admin/Subcategory.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Subcategory subcategory)
        {
            this.context.Subcategories.Add(subcategory);
            this.context.SaveChanges();

            ViewBag.Subcategories = context.Subcategories.Include(s => s.Category);
            ViewBag.Categories = this.context.Categories;

            return View("/Views/Admin/Subcategory.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Subcategory subcategory)
        {
            this.context.Subcategories.Remove(subcategory);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
