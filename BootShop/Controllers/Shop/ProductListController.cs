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

        public IActionResult Index(int? priceMin, int? priceMax, int? categoryId, string? orderBy, string? filterBy)
        {
            {
                //filtrace
                ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product);

                if (filterBy == "price")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax);

                }
                else if (filterBy == "category")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId);
                }
                else if (filterBy == "both")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId);
                }

                //řazení

                if (orderBy == "price")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).OrderBy(v => v.PriceDiscount);
                }
                else if (orderBy == "name")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).OrderBy(v => v.Product.Name);
                }

                // řazení a filtrace
                if (orderBy == "price" && orderBy == "price")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax).OrderBy(v => v.PriceDiscount);
                }
                else if (orderBy == "price" && orderBy == "name")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax).OrderBy(v => v.Product.Name);
                }
                else if (filterBy == "category" && orderBy == "price")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId).OrderBy(v => v.PriceDiscount);
                }
                else if (filterBy == "category" && orderBy == "name")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId).OrderBy(v => v.Product.Name);
                }
                else if (filterBy == "both" && orderBy == "price")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId).OrderBy(v => v.PriceDiscount);
                }
                else if (filterBy == "both" && orderBy == "name")
                {
                    ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId).OrderBy(v => v.Product.Name);
                }


                ViewBag.PriceMax = context.ProductVariants.Max(v => v.PriceDiscount);
                ViewBag.PriceMin = context.ProductVariants.Min(v => v.PriceDiscount);
                ViewBag.Categories = this.context.Categories;


                return View("/Views/Shop/ProductList.cshtml");
            }

        }
    }
}

