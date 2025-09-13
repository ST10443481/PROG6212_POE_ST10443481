using Microsoft.AspNetCore.Mvc;

namespace MonthlyClaimSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return RedirectToAction("Login", "Home");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Home");
        }
    }
}
