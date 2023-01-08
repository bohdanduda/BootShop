using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BootShop.Controllers.Shop
{
    public class HomeController : Controller
    {
        private BootShopContext context = new BootShopContext();

        public IActionResult Index()
        {
            ViewBag.ProductVariants = this.context.ProductVariants.OrderByDescending(v => v.Id).Take(8).Include(v => v.Product);
            
            return View("/Views/Shop/Index.cshtml");
        }
    }
}

