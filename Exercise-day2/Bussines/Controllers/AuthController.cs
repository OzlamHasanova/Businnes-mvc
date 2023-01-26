using Microsoft.AspNetCore.Mvc;

namespace Bussines.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
