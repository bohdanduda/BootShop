using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class OrderController : Controller
    {
        private BootShopContext context = new BootShopContext();
        public IActionResult Index()
        {
            ViewBag.Orders = this.context.Orders
                .Include(o => o.Customer)
                .Include(o => o.DeliveryMethod)
                .Include(o => o.PaymentMethod)
                .OrderByDescending(o => o.CreatedAt)
                .ToList();

            ViewBag.OrderItems = this.context.OrderItems
                .Include(i => i.ProductVariant)
                .ToList();

            ViewBag.ProductVariants = this.context.ProductVariants
                .Include(v => v.Product)
                .Include(v => v.Color)
                .ToList();

            return View("/Views/Admin/Orders.cshtml");
        }
    }
}
