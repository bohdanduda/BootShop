using BootShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BootShop.Controllers.Admin
{
    public class AdminLoginController : Controller
    {
        public BootShopContext context = new BootShopContext();
        public IActionResult Index(string? username, string? password)
        {
            AdminData adminData = this.context.AdminDatas.Where(x => x.Username == username).FirstOrDefault();

            if (adminData==null || adminData.Password != password)
            {
                ViewBag.Message = "Zadaná kombinace jména a hesla není správná";
                ViewBag.Username = username;
                return View("/Views/Admin/AdminLogin.cshtml");
            }

            return View("/Views/Admin/AdminHome.cshtml");
        }
    }
}
