using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;


namespace BootShop.Controllers.Shop
{
    public class CustomerInfoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            string? customerInfoJson = this.HttpContext.Session.GetString("customerInfo");

            Customer customerInfo = customerInfoJson != null 
                ? (Customer)JsonSerializer.Deserialize<Customer>(customerInfoJson)
                : new("", "", "", "", "", "", "");

            ViewBag.phone = customerInfo.Phone;
            ViewBag.email = customerInfo.Email;
            ViewBag.name = customerInfo.Name;
            ViewBag.surname = customerInfo.Surname;
            ViewBag.address =customerInfo.Address;
            ViewBag.town = customerInfo.Town;
            ViewBag.zipCode = customerInfo.Zipcode;

            return View("/Views/Shop/CustomerInfo.cshtml");
        }

        [HttpPost]
        public IActionResult Index(string? name, string? surname, string? address, string? town, string? postalCode, string? phone, string? email)
        { 
            Customer customerInfo = new(name, surname, address, town, postalCode, phone, email);
            this.HttpContext.Session.SetString("customerInfo", JsonSerializer.Serialize(customerInfo));

            return RedirectToAction("Index", "ShippingAndPayment");
        }
    }
}
