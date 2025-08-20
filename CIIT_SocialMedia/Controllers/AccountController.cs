using Microsoft.AspNetCore.Mvc;

namespace CIIT_SocialMedia.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

    }
}
