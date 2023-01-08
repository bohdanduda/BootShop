using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using BootShop.Models;

namespace BootShop.Controllers.Admin
{
    public class ColorController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Colors = this.context.Colors.ToList();

            return View("/Views/Admin/Color.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Color color)
        {
            this.context.Colors.Add(color);
            this.context.SaveChanges();
            ViewBag.Colors = this.context.Colors.ToList();

            return View("/Views/Admin/Color.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Color color)
        {
            this.context.Remove(color);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Color color)
        {
            ViewBag.Color = this.context.Colors.Find(color.Id);

            return View("/Views/Admin/ColorEdit.cshtml");
        }


        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(Color color)
        {
            this.context.Colors.Update(color);
            this.context.SaveChanges();

            ViewBag.Color = color;
            return View("/Views/Admin/ColorEdit.cshtml");
        }
    }
}