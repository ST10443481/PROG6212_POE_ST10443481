using Microsoft.AspNetCore.Mvc;

namespace MonthlyClaimSystem.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult ApprovalDashboard()
        {
            return View();
        }

        public IActionResult ReviewClaim(int id)
        {
            ViewBag.ClaimId = id;
            return View();
        }
    }
}
