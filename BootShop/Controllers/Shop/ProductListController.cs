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
                ViewBag.productVariants = this.context.ProductVariants.Include(v => v.Product);

                //filtrace

                if (filterBy == "price")
                {
                    this.FilterByPrice(priceMin, priceMax);
                }
                else if (filterBy == "category")
                {
                    this.FilterByCategory(categoryId);
                }
                else if (filterBy == "both")
                {
                    this.FilterByBoth(priceMin, priceMax, categoryId);
                }

                //řazení

                if (orderBy == "price")
                {
                    this.OrderByPrice();
                }
                else if (orderBy == "name")
                {
                    this.OrderByName();
                }

                // řazení a filtrace
                if (orderBy == "price" && orderBy == "price")
                {
                    this.FilterByPriceOrderByPrice(priceMin, priceMax);
                }
                else if (orderBy == "price" && orderBy == "name")
                {
                    this.FilterByPriceOrderByName(priceMin, priceMax);
                }
                else if (filterBy == "category" && orderBy == "price")
                {
                    this.FilterByCategoryOrderByPrice(categoryId);
                }
                else if (filterBy == "category" && orderBy == "name")
                {
                    this.FilterByCategoryOrderByName(categoryId);
                }
                else if (filterBy == "both" && orderBy == "price")
                {
                    this.FilterByBothOrderByPrice(priceMin, priceMax, categoryId);
                }
                else if (filterBy == "both" && orderBy == "name")
                {
                    this.FilterByBothOrderByName(priceMin, priceMax, categoryId);
                }

                ViewBag.PriceMax = context.ProductVariants.Max(v => v.PriceDiscount);
                ViewBag.PriceMin = context.ProductVariants.Min(v => v.PriceDiscount);
                ViewBag.Categories = this.context.Categories;


                return View("/Views/Shop/ProductList.cshtml");
            }
        }
        public void FilterByPrice(int? priceMin, int? priceMax)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax);
        }
        public void FilterByCategory(int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId);
        }
        public void FilterByBoth(int? priceMin, int? priceMax, int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId);
        }
        public void OrderByPrice()
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).OrderBy(v => v.PriceDiscount);
        }
        public void OrderByName()
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).OrderBy(v => v.Product.Name);
        }
        public void FilterByPriceOrderByPrice(int? priceMin, int? priceMax)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax).OrderBy(v => v.PriceDiscount);
        }
        public void FilterByPriceOrderByName(int? priceMin, int? priceMax)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax).OrderBy(v => v.Product.Name);
        }
        public void FilterByCategoryOrderByPrice(int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId).OrderBy(v => v.PriceDiscount);
        }

        public void FilterByCategoryOrderByName(int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.Product.CategoryId == categoryId).OrderBy(v => v.Product.Name);
        }

        public void FilterByBothOrderByPrice(int? priceMin, int? priceMax, int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId).OrderBy(v => v.PriceDiscount);
        }

        public void FilterByBothOrderByName(int? priceMin, int? priceMax, int? categoryId)
        {
            ViewBag.ProductVariants = this.context.ProductVariants.Include(v => v.Product).Where(v => v.PriceDiscount >= priceMin && v.PriceDiscount <= priceMax && v.Product.CategoryId == categoryId).OrderBy(v => v.Product.Name);
        }
    }
}

