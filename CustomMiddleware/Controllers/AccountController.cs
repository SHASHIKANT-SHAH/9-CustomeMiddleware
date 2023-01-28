using Microsoft.AspNetCore.Mvc;

namespace CustomMiddleware.Controllers
{
    public class AccountController : Controller
    {
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
