using Microsoft.AspNetCore.Mvc;

namespace MvcPartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
