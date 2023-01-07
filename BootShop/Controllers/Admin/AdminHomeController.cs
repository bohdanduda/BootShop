using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class AdminHomeController : Controller
    {
        public IActionResult AdminHome()
        {
            return View("/Views/Admin/AdminHome.cshtml");
        }
    }
}
