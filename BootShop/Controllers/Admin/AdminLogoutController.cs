using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class AdminLogoutController : Controller
    {
        public IActionResult Logout()
        {
            this.HttpContext.Session.Remove("login");

            return RedirectToAction("Index", "AdminLogin");
        }
    }
}
