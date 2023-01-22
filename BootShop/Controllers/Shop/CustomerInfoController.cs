using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Shop
{
    public class CustomerInfoController : Controller
    {
        private BootShopContext context = new BootShopContext();
        public IActionResult Index(string? name, string? surname, string? address, string? town, string? postalCode, string? phone, string? email)
        {
            CustomerInfo customerInfo = new CustomerInfo(name, surname, address, town, postalCode, phone, email);
            string customerContact = $"{email}, {phone}, {name} {surname}";
            string customerAddress = $"{address}, {town}, {postalCode}";
            this.HttpContext.Session.SetString("customerContact", customerContact);
            this.HttpContext.Session.SetString("customerAddress", customerAddress);

            ViewBag.name=name;
            ViewBag.surname=surname;
            ViewBag.address=address;
            ViewBag.town=town;
            ViewBag.postalCode=postalCode;

            return View("/Views/Shop/CustomerInfo.cshtml");
        }
    }
}
