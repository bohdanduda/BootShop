using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class CategoryController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Categories = this.context.Categories.Include(c => c.Subcategories); // https://learn.microsoft.com/en-us/ef/ef6/querying/related-data ;

            return View("/Views/Admin/Category.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Category category)
        {
            this.context.Categories.Add(category);
            this.context.SaveChanges();
            ViewBag.Categories = this.context.Categories.Include(c => c.Subcategories);

            return View("/Views/Admin/Category.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Category category)
        {
            List<Subcategory> subcategories = this.context.Subcategories.Where(s => s.CategoryId == category.Id).ToList();
            this.context.Subcategories.RemoveRange(subcategories);
            this.context.Categories.Remove(category);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Category category)
        {
            ViewBag.Category = this.context.Categories.Find(category.Id);
            ViewBag.SubCategories = this.context.Subcategories.Where(s => s.CategoryId == category.Id).ToList();

            return View("/Views/Admin/CategoryEdit.cshtml");
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(Category category)
        {
            this.context.Categories.Update(category);
            this.context.SaveChanges();

            ViewBag.Category = category;
            ViewBag.SubCategories = this.context.Subcategories.Where(s => s.CategoryId == category.Id).ToList();

            return View("/Views/Admin/CategoryEdit.cshtml");
        }
    }
}
