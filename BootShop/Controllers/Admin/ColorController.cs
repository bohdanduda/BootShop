using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using BootShop.Models;

namespace BootShop.Controllers.Admin
{
    public class ColorController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Color()
        {
            ViewBag.Colors = this.context.Color.ToList();

            return View("/Views/Admin/Color.cshtml");
        }

        [HttpPost]
        public IActionResult Color(Color color)
        {
            this.context.Color.Add(color);
            this.context.SaveChanges();
            ViewBag.Colors = this.context.Color.ToList();

            return View("/Views/Admin/Color.cshtml");
        }
    }
}