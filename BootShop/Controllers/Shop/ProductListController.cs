using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace BootShop.Controllers.Shop
{
    public class ProductListController : Controller
    {
        private BootShopContext context = new BootShopContext();

        public IActionResult Index()
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product);
            
            return View("/Views/Shop/ProductList.cshtml");
        }
    }
}

