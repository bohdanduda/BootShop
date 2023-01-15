using BootShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class SizeController : AdminBaseController
    {
        private BootShopContext context = new BootShopContext();

        [HttpGet]
        public IActionResult Index()
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            ViewBag.Sizes = this.context.Sizes.ToList();

            return View("/Views/Admin/Size.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Size size)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            this.context.Sizes.Add(size);
            this.context.SaveChanges();
            ViewBag.Sizes = this.context.Sizes.ToList();

            return View("/Views/Admin/Size.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Size size)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            this.context.Sizes.Remove(size);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
