using Microsoft.AspNetCore.Mvc;
using BootShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting.Server;

namespace BootShop.Controllers.Admin
{
    public class ProductPhotoController : Controller
    {
        private BootShopContext context = new BootShopContext();
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.ProductPhotos = this.context.ProductPhotos.Include(pp => pp.Product);
            ViewBag.Products = this.context.Products;

            return View("Views/Admin/ProductPhoto.cshtml");
        }

        [HttpPost]
        public IActionResult Index(IFormFile image, int productId)
        {
            string ImageName = image.FileName;
            string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productImages", ImageName);

            using (FileStream stream = new FileStream(SavePath, FileMode.Create))
            {
                image.CopyTo(stream);
            }

            ProductPhoto productPhoto = new ProductPhoto()
            {
                Filename = ImageName,
                ProductId = productId
            };

            this.context.ProductPhotos.Add(productPhoto);
            this.context.SaveChanges();

            ViewBag.ProductPhotos = this.context.ProductPhotos.Include(pp => pp.Product);
            ViewBag.Products = this.context.Products;

            return View("Views/Admin/ProductPhoto.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(ProductPhoto productPhoto)
        {
            productPhoto = this.context.ProductPhotos.Find(productPhoto.Id);
            
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/productImages", productPhoto.Filename);
            
            FileInfo file = new FileInfo(filePath);
            if (file.Exists)
            {
                file.Delete();
            }

            this.context.ProductPhotos.Remove(productPhoto);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }
    }


}
