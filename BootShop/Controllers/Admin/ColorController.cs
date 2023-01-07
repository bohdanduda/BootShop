using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using BootShop.Models;

namespace BootShop.Controllers.Admin
{
    public class ColorController : Controller
    {
        private BootShopContext context = new BootShopContext();
        public IActionResult Color()
        {
            ViewBag.Colors = this.context.Color.ToList();

            return View("/Views/Admin/Color.cshtml");
        }
    }
}
