using Microsoft.AspNetCore.Mvc;

namespace BootShop.Controllers.Admin
{
    public class AdminHomeController : AdminBaseController
    {
        public IActionResult AdminHome()
        {
            RedirectToActionResult? checkloginResult = this.checkLogin();
            if (checkloginResult != null)
            {
                return checkloginResult;
            }
            
            return View("/Views/Admin/AdminHome.cshtml");
        }
    }
}
