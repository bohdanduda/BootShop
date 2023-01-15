using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BootShop.Controllers.Shop
{
    public class ProductDetailController : Controller
    {
        private BootShopContext context = new BootShopContext();

        public IActionResult ProductDetail(ProductVariant inputProductVariant)
        {
            ProductVariant? productVariant = this.context.ProductVariants
                .Include(pv => pv.Product)
                .Include(pv => pv.Color)
                .Include(pv => pv.Product.Brand)
                .Include(pv => pv.Product.Category)
                .Include(pv => pv.Product.Subcategory)
                .FirstOrDefault(pv => pv.Id == inputProductVariant.Id);

            if (productVariant == null)
            {
                throw new Exception("Varianta produktu neexistuje");
            }

            ViewBag.ProductVariant = productVariant;
            ViewBag.DefaultProductVariantsForColors = this.GetDefaultVariantsForProductColors(productVariant.ProductId);
            ViewBag.DefaultProductVariantsForSizes = this.GetDefaultVariantsForProductSizes(productVariant.ProductId);
            ViewBag.ProductPhotos = this.context.ProductPhotos.Where(pp => pp.ProductId == productVariant.ProductId);

            return View("/Views/Shop/ProductDetail.cshtml");
        }

        private List<ProductVariant> GetDefaultVariantsForProductColors(int productId)
        {
            List<ProductVariant> allProductVariants = this.context.ProductVariants
                .Where(pv => pv.ProductId == productId)
                .OrderBy(pv => pv.ColorId)
                .Include(pv => pv.Color)
                .ToList();

            List<Color> productColors = new List<Color>();
            List<ProductVariant> defaultVariants = new List<ProductVariant>();
            foreach (ProductVariant productVariant in allProductVariants)
            {
                if (!productColors.Contains(productVariant.Color))
                {
                    productColors.Add(productVariant.Color);
                    defaultVariants.Add(productVariant);
                }
            }

            return defaultVariants;
        }

        private List<ProductVariant> GetDefaultVariantsForProductSizes(int productId)
        {
            List<ProductVariant> allProductVariants = this.context.ProductVariants
                .Where(pv => pv.ProductId == productId)
                .OrderBy(pv => pv.SizeId)
                .ToList();

            List<int> productSizes = new List<int>();
            List <ProductVariant> defaultVariants = new List<ProductVariant>();
            foreach (ProductVariant productVariant in allProductVariants)
            {
                if (!productSizes.Contains(productVariant.SizeId))
                {
                    productSizes.Add(productVariant.SizeId);
                    defaultVariants.Add(productVariant);
                }
            }

            return defaultVariants;
        }
    }
}
