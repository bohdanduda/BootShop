using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class SizeController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Sizes = this.context.Size.ToList();

            return View("/Views/Admin/Size.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Size size)
        {
            this.context.Size.Add(size);
            this.context.SaveChanges();
            ViewBag.Sizes = this.context.Size.ToList();

            return View("/Views/Admin/Size.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Size size)
        {
            this.context.Size.Remove(size);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
