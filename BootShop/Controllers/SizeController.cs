using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace BootShop.Controllers
{
    public class SizeController : Controller
    {
        public IActionResult Size()
        {
            Collection<Size> sizes = new Collection<Size>();
            sizes.Add(new Size(
                23));
            sizes.Add(new Size(
                24));
            sizes.Add(new Size(
                25));

            ViewBag.Size = sizes;

            return View("/Views/Admin/Size.cshtml");
        }
    }
}
