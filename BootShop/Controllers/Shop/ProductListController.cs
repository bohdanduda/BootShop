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

        public IActionResult Index(int? priceFrom, int? priceTo, int? categoryId, string? orderBy)
        {
            {
                IQueryable<ProductVariant> productVariants = this.context.ProductVariants.Include(v => v.Product);
                
                if (priceFrom != null)
                {
                    productVariants = productVariants.Where(pv => pv.PriceDiscount >= priceFrom);
                }

                if (priceTo != null)
                {
                    productVariants = productVariants.Where(pv => pv.PriceDiscount <= priceTo);
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

                int priceMax = (int)this.context.ProductVariants.Max(v => v.PriceDiscount);
                int priceMin = (int)this.context.ProductVariants.Min(v => v.PriceDiscount);

                ViewBag.productVariants = productVariants;
                ViewBag.PriceMax = priceMax;
                ViewBag.PriceMin = priceMin;
                ViewBag.PriceTo = priceTo == null ? priceMax : priceTo;
                ViewBag.PriceFrom = priceFrom == null ? priceMin : priceFrom;
                ViewBag.Categories = this.context.Categories;
                ViewBag.CategoryId = categoryId;
                ViewBag.OrderBy = orderBy;

                return View("/Views/Shop/ProductList.cshtml");
            }
        }
    }
}

