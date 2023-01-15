using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class AdminBaseController : Controller
    {
        protected RedirectToActionResult? checkLogin()
        {
            string? username = this.HttpContext.Session.GetString("login");
            if (username == null)
            {
                return RedirectToAction("Index", "AdminLogin");
            }

            ViewBag.LoggedInUsername = username;
            return null;
        }
    }
}
