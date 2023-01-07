using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class SizeController : Controller
    {
        private BootShopContext bootShopContext = new BootShopContext();

        public IActionResult Size()
        {
            ViewBag.Sizes = this.bootShopContext.Size.ToList();

            return View("/Views/Admin/Size.cshtml");
        }
    }
}
