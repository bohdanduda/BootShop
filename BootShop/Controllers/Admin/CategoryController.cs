using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = this.context.Category.ToList();

            return View("/Views/Admin/Category.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            this.context.Category.Add(category);
            this.context.SaveChanges();
            ViewBag.Categories = this.context.Category.ToList();

            return View("/Views/Admin/Category.cshtml");
        }
    }
}
