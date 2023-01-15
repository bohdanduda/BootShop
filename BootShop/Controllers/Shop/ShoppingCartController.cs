using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace BootShop.Controllers.Shop
{
    public class ShoppingCartController : Controller
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            ShoppingCart shoppingCart = new ShoppingCart();

            string? shoppingCartJson = this.HttpContext.Session.GetString("shoppingCart");

            if (shoppingCartJson != null)
            {
                shoppingCart = (ShoppingCart)JsonSerializer.Deserialize<ShoppingCart>(shoppingCartJson);
            }

            ViewBag.ShoppingCart = shoppingCart;

            return View("/Views/Shop/ShoppingCart.cshtml");
        }

        [HttpGet]
        public IActionResult AddItem(ProductVariant inputProductVariant)
        {
            ProductVariant? productVariant = this.context.ProductVariants
                .Include(pv => pv.Product)
                .Include(pv => pv.Color)
                .FirstOrDefault(pv => pv.Id == inputProductVariant.Id);

            if (productVariant == null)
            {
                throw new Exception("Varianta produktu neexistuje");
            }

            ShoppingCart shoppingCart = new ShoppingCart();

            string? shoppingCartJson = this.HttpContext.Session.GetString("shoppingCart");

            if (shoppingCartJson != null)
            {
                shoppingCart = (ShoppingCart)JsonSerializer.Deserialize<ShoppingCart>(shoppingCartJson);
            }

            ShoppingCartItem? existingItemForVariant = shoppingCart.Items.Find(i => i.ProductVariant.Id == productVariant.Id);

            if (existingItemForVariant != null)
            {
                if (existingItemForVariant.Amount < productVariant.RemainingStock)
                {
                    existingItemForVariant.Amount++;
                }
            }
            else
            {
                shoppingCart.Items.Add(new ShoppingCartItem()
                {
                    ProductVariant = productVariant,
                    Amount = 1,
                });
            }

            this.HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DecreaseItem(ProductVariant inputProductVariant)
        {
            ProductVariant? productVariant = this.context.ProductVariants
                .FirstOrDefault(pv => pv.Id == inputProductVariant.Id);

            if (productVariant == null)
            {
                throw new Exception("Varianta produktu neexistuje");
            }

            ShoppingCart shoppingCart = new ShoppingCart();

            string? shoppingCartJson = this.HttpContext.Session.GetString("shoppingCart");

            if (shoppingCartJson == null)
            {
                throw new Exception("Nelze snížit počet položky, košík je prázdný");
            }

            shoppingCart = (ShoppingCart)JsonSerializer.Deserialize<ShoppingCart>(shoppingCartJson);

            ShoppingCartItem? existingItemForVariant = shoppingCart.Items.Find(i => i.ProductVariant.Id == productVariant.Id);

            if (existingItemForVariant == null)
            {
                throw new Exception("Nelze snížit počet položky, která není v košíku");
            }


            if (existingItemForVariant.Amount > 0)
            {
                existingItemForVariant.Amount--;
            }


            this.HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult RemoveItem(ProductVariant inputProductVariant)
        {
            ProductVariant? productVariant = this.context.ProductVariants
                .FirstOrDefault(pv => pv.Id == inputProductVariant.Id);

            if (productVariant == null)
            {
                throw new Exception("Varianta produktu neexistuje");
            }

            ShoppingCart shoppingCart = new ShoppingCart();

            string? shoppingCartJson = this.HttpContext.Session.GetString("shoppingCart");

            if (shoppingCartJson == null)
            {
                throw new Exception("Nelze odebrat položku z prázdného košíku");
            }

            shoppingCart = (ShoppingCart)JsonSerializer.Deserialize<ShoppingCart>(shoppingCartJson);

            ShoppingCartItem existingItemForVariant = shoppingCart.Items.Find(i => i.ProductVariant.Id == productVariant.Id);

            if (existingItemForVariant == null)
            {
                throw new Exception("Nelze odebrat položku, která není v košíku");
            }

            shoppingCart.Items.Remove(existingItemForVariant);

            this.HttpContext.Session.SetString("shoppingCart", JsonSerializer.Serialize(shoppingCart));

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Clear()
        {
            this.HttpContext.Session.Remove("shoppingCart");

            return RedirectToAction("Index");
        }
    }
}

