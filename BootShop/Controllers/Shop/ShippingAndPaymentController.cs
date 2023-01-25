using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using static NHibernate.Engine.Query.CallableParser;
using System.Xml.Linq;
using System.Text.Json;

namespace BootShop.Controllers.Shop
{
    public class ShippingAndPaymentController : Controller
    {
        private BootShopContext context = new BootShopContext();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DeliveryMethods = this.context.DeliveryMethods;
            ViewBag.PaymentMethods = this.context.PaymentMethods;

            string? customerInfoJson = this.HttpContext.Session.GetString("customerInfo");

            if (customerInfoJson != null)
            {
                Customer customerInfo = (Customer)JsonSerializer.Deserialize<Customer>(customerInfoJson);

                ViewBag.customerInfo = $"{customerInfo.Name} {customerInfo.Surname}, {customerInfo.Phone}, {customerInfo.Email}";
                ViewBag.customerAddress = $"{customerInfo.Address}, {customerInfo.Zipcode}, {customerInfo.Town}";
            }

            return View("/Views/Shop/ShippingAndPayment.cshtml");
        }

        [HttpPost]
        public IActionResult Index(int deliveryMethod, int paymentMethod)
        {
            string? customerInfoJson = this.HttpContext.Session.GetString("customerInfo");

            if (customerInfoJson == null)
            {
                throw new Exception("Objednávku nelze vytvořit: nejsou zadány údaje zákazníka");
            }

            string? shoppingCartJson = this.HttpContext.Session.GetString("shoppingCart");
            if (shoppingCartJson == null)
            {
                throw new Exception("Objednávku nelze vytvořit: neexistuje košík");
            }

            Customer customerInfo = (Customer)JsonSerializer.Deserialize<Customer>(customerInfoJson);
            this.context.CustomerInfos.Add(customerInfo);
            this.context.SaveChanges();

            ShoppingCart shoppingCart = (ShoppingCart)JsonSerializer.Deserialize<ShoppingCart>(shoppingCartJson);

            Order order = new Order();
            order.CreatedAt = DateTime.Now;
            order.TotalPrice = shoppingCart.GetTotalPrice();
            order.CustomerId = customerInfo.Id;
            order.DeliveryMethodId = deliveryMethod;
            order.PaymentMethodId = paymentMethod;

            this.context.Orders.Add(order);
            this.context.SaveChanges();

            foreach (ShoppingCartItem shoppingCartItem in shoppingCart.Items)
            {
                OrderItem orderItem = new OrderItem();
                orderItem.OrderId = order.Id;
                orderItem.ProductVariantId = shoppingCartItem.ProductVariant.Id;
                orderItem.Quantity = shoppingCartItem.Amount;
                orderItem.UnitPrice = shoppingCartItem.ProductVariant.PriceDiscount;
                orderItem.TotalPrice = shoppingCartItem.Amount * shoppingCartItem.ProductVariant.PriceDiscount;

                ProductVariant productVariant = this.context.ProductVariants.Find(shoppingCartItem.ProductVariant.Id);
                productVariant.RemainingStock -= shoppingCartItem.Amount;

                this.context.OrderItems.Add(orderItem);
                this.context.SaveChanges();
            }

            this.HttpContext.Session.Remove("shoppingCart");

            return RedirectToAction("Index", "OrderComplete");
        }
    }
}
