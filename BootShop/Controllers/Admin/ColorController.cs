using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using BootShop.Models;

namespace BootShop.Controllers.Admin
{
    public class ColorController : AdminBaseController
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

            ViewBag.Colors = this.context.Colors.ToList();

            return View("/Views/Admin/Color.cshtml");
        }

        [HttpPost]
        public IActionResult Index(Color color)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            this.context.Colors.Add(color);
            this.context.SaveChanges();
            ViewBag.Colors = this.context.Colors.ToList();

            return View("/Views/Admin/Color.cshtml");
        }

        [HttpGet]
        public IActionResult Delete(Color color)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            this.context.Remove(color);
            this.context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(Color color)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            ViewBag.Color = this.context.Colors.Find(color.Id);

            return View("/Views/Admin/ColorEdit.cshtml");
        }


        [HttpPost]
        [ActionName("Edit")]
        public IActionResult EditPost(Color color)
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }

            this.context.Colors.Update(color);
            this.context.SaveChanges();

            ViewBag.Color = color;
            return View("/Views/Admin/ColorEdit.cshtml");
        }
    }
}