using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using BootShop.Models;

namespace BootShop.Controllers.Admin
{
    public class ColorController : Controller
    {
        public IActionResult Color()
        {
            Collection<Color> colors = new Collection<Color>();

            colors.Add(new Color(1, "Červená", "#FF0000"));
            colors.Add(new Color(2, "Modrá", "#0000FF"));
            colors.Add(new Color(3, "Zelená", "#00FF00"));
            colors.Add(new Color(4, "Černá", "#000000"));
            colors.Add(new Color(3, "Bílá", "#FFFFFF"));

            ViewBag.Colors = colors;
            return View("/Views/Admin/Color.cshtml");
        }
    }
}
