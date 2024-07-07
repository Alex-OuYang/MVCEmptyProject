using Microsoft.AspNetCore.Mvc;

namespace Video.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
