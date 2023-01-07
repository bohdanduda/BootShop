using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class SubcategoryController : Controller
    {
        private BootShopContext context = new();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Subcategories = this.context.Subcategory;
            ViewBag.Categories = this.context.Category;
            return View("/Views/Admin/Subcategory.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Subcategory subcategory)
        {
            this.context.Subcategory.Add(subcategory);
            this.context.SaveChanges();

            ViewBag.Categories = this.context.Category;
            ViewBag.Subcategories = context.Subcategory;

            return View("/Views/Admin/Subcategory.cshtml");
        }
    }
}
