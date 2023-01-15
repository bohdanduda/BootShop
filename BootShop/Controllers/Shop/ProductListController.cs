using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NHibernate.Engine;
using System.Collections.ObjectModel;

namespace BootShop.Controllers.Shop
{
    public class ProductListController : Controller
    {
        private BootShopContext context = new BootShopContext();

        public IActionResult Index(int? priceMin, int? priceMax, int? categoryId, string? orderBy)
        {
            {
                IQueryable<ProductVariant> productVariants = this.context.ProductVariants.Include(v => v.Product);
                
                if (priceMin != null)
                {
                    productVariants = productVariants.Where(pv => pv.PriceDiscount >= priceMin);
                }

                if (priceMax != null)
                {
                    productVariants = productVariants.Where(pv => pv.PriceDiscount <= priceMax);
                }

                if (categoryId != null)
                {
                    productVariants = productVariants.Where(pv => pv.Product.CategoryId == categoryId);
                }

                if (orderBy == "price")
                {
                    productVariants = productVariants.OrderBy(pv => pv.PriceDiscount);
                }

                if (orderBy == "name")
                {
                    productVariants = productVariants.OrderBy(pv => pv.Product.Name);
                }

                ViewBag.productVariants = productVariants;
                ViewBag.PriceMax = context.ProductVariants.Max(v => v.PriceDiscount);
                ViewBag.PriceMin = context.ProductVariants.Min(v => v.PriceDiscount);
                ViewBag.Categories = this.context.Categories;


                return View("/Views/Shop/ProductList.cshtml");
            }
        }
    }
}

